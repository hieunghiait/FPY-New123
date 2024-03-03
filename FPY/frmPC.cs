using FPY.Reports;
using FPY.Utils;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPY
{
    public partial class frmPC : Form
    {
        public frmPC()
        {
            InitializeComponent();
            this.Text = "PC FORM"; 
        }
        #region Function 
        //hàm check WorkOrderNo có tồn tại trogn database không 
        public bool CheckWorkOrderNo(string workOrderNo)
        {
            using (var db = new FPYEntities())
            {
                var workOrder = db.WorkOrders.FirstOrDefault(p => p.WorkOrderNo == workOrderNo);
                if (workOrder != null)
                {
                    return true;
                }
                return false;
            }
        }
        //clear input data 
        public void ClearData()
        {
            txtPartNo.Text = "";
            txtWO.Text = "";
            txtOutputQty.Text = "";
            txtDescription.Text = "";
        }
        //create PartNo
        public void CreatePartNo(string PartNo)
        {
           try
            {
                using (var db = new FPYEntities())
                {
                    //Khởi tạo đối tượng Product 
                    var partNo = new Product();

                    partNo.PartNo = PartNo;
                    db.Products.Add(partNo);
                    db.SaveChanges();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        public void  validationInput()
        {
            if(txtPartNo.Text == "")
            {
                MessageBox.Show("PartNo is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtWO.Text == "")
            {
                MessageBox.Show("WorkOrderNo is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtOutputQty.Text == "")
            {
                MessageBox.Show("OutputQuantity is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Sự kiện cập nhật 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                validationInput(); 
                using (var db = new FPYEntities())
                {
                    var partNo = txtPartNo.Text.Trim(); //sanitize input
                    var workOrderNo = txtWO.Text.Trim(); //sanitize input
                    var outputQty = txtOutputQty.Text.Trim(); //sanitize input
                    var description = txtDescription.Text.Trim(); //sanitize input

                   // Kiểm tra partNo đã tồn tại trong database chưa 
                    var findPartNo = db.Products.FirstOrDefault(p => p.PartNo == partNo);
                    //Nếu chưa tồn tại trong database 
                    if (findPartNo == null) // 
                    {
                        //Thực hiện tạo mới PartNo
                        CreatePartNo(partNo);
                        // After creating the new PartNo, fetch it from the database to get its ID.
                        findPartNo = db.Products.FirstOrDefault(p => p.PartNo == partNo);
                    }
                    var workOrder = new WorkOrder();
                    if(partNo != null)
                    {
                        workOrder.PartNo = findPartNo.ProductID;
                    }else
                    {
                        MessageBox.Show("PartNo creation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    workOrder.WorkOrderNo = workOrderNo;
                    workOrder.OutputQuantityPC = Convert.ToInt32(outputQty);
                    workOrder.Description = description;
                    //Cập nhật thời gian 
                    workOrder.Timestamp = DateTime.Now;

                    if (CheckWorkOrderNo(workOrder.WorkOrderNo))
                    {
                        MessageBox.Show("WorkOrderNo already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    db.WorkOrders.Add(workOrder);

                    // Tạo bản ghi cho CNC với điều kiện như đề cập.
                    var cncRecord = new CNCOperation();
                    //input quantity của CNC sẽ bằng với output quantity của PC
                    cncRecord.InputQuantityCNC = workOrder.OutputQuantityPC;
                    cncRecord.WorkOrderID = workOrder.WorkOrderID;
                    // Set other necessary properties for CNC record
                    cncRecord.Timestamp = DateTime.Now;
                    // Add more properties if needed

                    db.CNCOperations.Add(cncRecord);

                    // Lưu tất cả thay đổi vào cơ sở dữ liệu.
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Data has been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Load lại dữ liệu cho PC
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void dgvPC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
        private void BindFirstRowToInputs()
        {
            if (dgvPC.Rows.Count > 0)
            {
                var row = dgvPC.Rows[0];
                txtPartNo.Text = Convert.ToString(row.Cells["PartNo"].Value);
                txtWO.Text = Convert.ToString(row.Cells["WorkOrderNo"].Value);
                txtOutputQty.Text = Convert.ToString(row.Cells["OutputQuantityPC"].Value);
                txtDescription.Text = Convert.ToString(row.Cells["Description"].Value);
            }
        }
        private void frmPC_Load(object sender, EventArgs e)
        {
            //Load data
            LoadData();
            LoadDataComboBox();
        }
        public void LoadData()
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    // Giả sử 'PartNoID' là khóa ngoại trong 'WorkOrders' liên kết với bảng 'PartNo'
                    var listPC = (from wo in db.WorkOrders
                                  join pn in db.Products on wo.PartNo equals pn.ProductID // ID là khóa chính trong bảng PartNo
                                  select new
                                  {
                                      pn.PartNo,
                                      wo.WorkOrderNo,
                                      wo.OutputQuantityPC,
                                      wo.Description,
                                      wo.Timestamp,
                                     
                                  }).ToList();
                    dgvPC.DataSource = listPC;
                }
                //select phần tử đầu tiên 
                dgvPC.Rows[0].Selected = true;
                BindFirstRowToInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var workOrderNo = txtWO.Text.Trim(); //sanitize input
                var partNo = txtPartNo.Text.Trim(); //sanitize input
                using (var db = new FPYEntities())
                {
                    var workOrder = db.WorkOrders.FirstOrDefault(p => p.WorkOrderNo == txtWO.Text);
                    if (workOrder != null)
                    {
                        db.WorkOrders.Remove(workOrder);
                        if (db.SaveChanges() > 0)
                        {
                           DialogResult result = MessageBox.Show("Are you sure you want to delete this data ? " + workOrderNo + " and " + partNo, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.OK)
                            {
                                MessageBox.Show("Data has been deleted successfully");
                                LoadData(); 
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                return;
                            }
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Data has not been deleted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void txtPartNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtWO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPartNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var searchWO = txtWO.Text.Trim();
                    var searchPartNo = txtPartNo.Text.Trim();

                    // Using method syntax for LINQ query
                    var listPC = db.WorkOrders
                        .Join(db.Products, wo => wo.PartNo, pn => pn.ProductID, (wo, pn) => new { wo, pn })
                        .Where(x => x.wo.WorkOrderNo.Contains(searchWO) && x.pn.PartNo.Contains(searchPartNo))
                        .Select(x => new
                        {
                            PartNo = x.pn.PartNo,
                            WorkOrderNo = x.wo.WorkOrderNo,
                            OutputQuantityPC = x.wo.OutputQuantityPC,
                            Description = x.wo.Description,
                            Timestamp = x.wo.Timestamp,
                        })
                        .ToList();

                    if (listPC.Any()) // Checks if the list has any elements
                    {
                        dgvPC.DataSource = listPC;
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Assuming LoadData() refreshes dgvPC with default data
                    }
                }
            }
            catch (Exception ex)
            {
                // Consider logging the exception details
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public void LoadDataComboBox()
        {
            try
            {
                using (var context = new FPYEntities())
                {
                    var partNos = context.Products.Select(p => p.PartNo).ToList();
                    txtPartNo.DataSource = partNos;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtPartNo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPartNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                var workOrderNo = txtWO.Text.Trim();
                var partNo = txtPartNo.Text.Trim(); 
                var inputPartNo = txtPartNo.Text.Trim(); 
                var outputQty = txtOutputQty.Text.Trim(); 

                using (var db = new FPYEntities())
                {
                    var foundWorkOrder = db.WorkOrders.FirstOrDefault(p => p.WorkOrderNo == workOrderNo);
                    if (foundWorkOrder != null) // Nếu tìm thấy workOrderNo trong database 
                    {
                        var foundPartNo = db.Products.FirstOrDefault(p => p.PartNo == partNo);
                        if (partNo != null) // 
                        {
                            foundWorkOrder.PartNo = foundPartNo.ProductID;
                            foundWorkOrder.WorkOrderNo = workOrderNo;
                            foundWorkOrder.OutputQuantityPC = Convert.ToInt32(outputQty);
                            foundWorkOrder.Description = txtDescription.Text;
                            foundWorkOrder.Timestamp = DateTime.Now;
                            DialogResult result = MessageBox.Show("Are you sure you want to update this data?", "Update", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                if (db.SaveChanges() > 0)
                                {
                                    MessageBox.Show("Data has been updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Data has not been updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("PartNo not found");
                        }

                    }
                    else
                    {
                        MessageBox.Show("WorkOrderNo " + workOrderNo + " not exits in database");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frmMain();
            frm.Show();
        }

        private void dgvPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPC.Rows.Count > 0)
                {
                    var row = dgvPC.Rows[e.RowIndex];
                    txtPartNo.Text = Convert.ToString(row.Cells["PartNo"].Value);
                    txtWO.Text = Convert.ToString(row.Cells["WorkOrderNo"].Value);
                    txtOutputQty.Text = Convert.ToString(row.Cells["OutputQuantityPC"].Value);
                    txtDescription.Text = Convert.ToString(row.Cells["Description"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData(); 
                //Show message box
                MessageBox.Show("Data has been reloaded successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Xóa dữ liệu
        private void btnClearData_Click(object sender, EventArgs e)
        {
            ClearData(); 
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var listPC = (from wo in db.WorkOrders
                                  join pn in db.Products on wo.PartNo equals pn.ProductID
                                  select new
                                                                                                    {                                                                  
                                      pn.PartNo,
                                      wo.WorkOrderNo,
                                      wo.OutputQuantityPC,
                                      wo.Description,
                                      wo.Timestamp,
                                  }).ToList();
                    if (listPC.Count > 0)
                    {
                        //Tạo mới form Report
                        frmReport frmReport = new frmReport();
                        //Tạo mới ReportViewer
                        ReportViewer reportViewer = new ReportViewer();
                        //Gán ReportViewer vào form Report
                        frmReport.ReportViewer = reportViewer;
                        
                        frmReport.ReportViewer.LocalReport.DataSources.Add(new ReportDataSource("FPYDataSet", listPC));
                       
                        frmReport.ReportViewer.LocalReport.ReportPath = "Reports/rptPC.rdlc";
                        
                        frmReport.Show();
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtOutputQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPartNoSearch_TextChanged(object sender, EventArgs e)
        {
           var textBoxPartNum = txtPartNoSearch.Text.Trim();    
            using (var db = new FPYEntities())
            {
                try
                {
                    var data = (from cnc in db.CNCOperations
                                join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                join p in db.Products on wo.PartNo equals p.ProductID
                                where p.PartNo.Contains(textBoxPartNum)
                                select new
                                {
                                    p.PartNo,
                                    wo.WorkOrderNo,
                                    wo.OutputQuantityPC, 
                                    wo.Description,
                                    wo.Timestamp
                                }).ToList();
                    dgvPC.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtWOSearch_TextChanged(object sender, EventArgs e)
        {
            var textBoxWO = txtWOSearch.Text.Trim();
            using (var db = new FPYEntities())
            {
                try
                {
                    var data = (from cnc in db.CNCOperations
                                join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                join p in db.Products on wo.PartNo equals p.ProductID
                                where wo.WorkOrderNo.Contains(textBoxWO)
                                select new
                                {
                                    p.PartNo,
                                    wo.WorkOrderNo,
                                    wo.OutputQuantityPC, 
                                    wo.Description,
                                    wo.Timestamp
                                }).ToList();
                    dgvPC.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtOutputQty_TextChanged_1(object sender, EventArgs e)
        {
            //chỉ cho phép nhập số
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOutputQty.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtOutputQty.Text = txtOutputQty.Text.Remove(txtOutputQty.Text.Length - 1);
            }
        }
    }
}
