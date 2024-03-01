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
        }

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
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var workOrder = new WorkOrder();
                    var partNo = db.Products.FirstOrDefault(p => p.PartNo == txtPartNo.Text);
                    if (partNo == null)
                    {
                        MessageBox.Show("PartNo not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    workOrder.PartNo = partNo.ProductID;
                    workOrder.WorkOrderNo = txtWO.Text;
                    workOrder.OutputQuantityPC = Convert.ToInt32(txtOutputQty.Text);
                    workOrder.Description = txtDescription.Text;
                    workOrder.Timestamp = DateTime.Now;

                    if (CheckWorkOrderNo(workOrder.WorkOrderNo))
                    {
                        MessageBox.Show("WorkOrderNo already exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    db.WorkOrders.Add(workOrder);

                    // Tạo bản ghi cho CNC với điều kiện như đề cập.
                    var cncRecord = new CNCOperation();
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

            try
            {
                // Check if the click is on a valid row (not on the header)
                if (e.RowIndex >= 0 && dgvPC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    // Select the current row
                    dgvPC.CurrentRow.Selected = true;

                    // Retrieve the data from each cell and set it to the text boxes
                    txtWO.Text = dgvPC.Rows[e.RowIndex].Cells["WorkOrderNo"].Value.ToString();
                    txtPartNo.Text = dgvPC.Rows[e.RowIndex].Cells["PartNo"].Value.ToString();
                    txtOutputQty.Text = dgvPC.Rows[e.RowIndex].Cells["OutputQuantityPC"].Value.ToString();
                    txtDescription.Text = dgvPC.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void frmPC_Load(object sender, EventArgs e)
        {
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
                                      PartNo = pn.PartNo,
                                      wo.WorkOrderNo,
                                      wo.OutputQuantityPC,
                                      wo.Description,
                                      wo.Timestamp,
                                     
                                  }).ToList();
                    dgvPC.DataSource = listPC;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadDataWorkOrder()
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var workOrder = db.WorkOrders.FirstOrDefault(p => p.WorkOrderNo == txtWO.Text);
                    if (workOrder != null)
                    {
                        db.WorkOrders.Remove(workOrder);
                        if (db.SaveChanges() > 0)
                        {
                           DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Delete", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                MessageBox.Show("Data has been deleted successfully");
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
        
        public void LoadDataWO()
        {
            
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
            //search theo WorkOrderNo 
            try
            {
                using (var db = new FPYEntities())
                {
                    var search = txtWO.Text;
                    var listPC = (from wo in db.WorkOrders 
                                  join pn in db.Products on wo.PartNo
                                  equals pn.ProductID 
                                  where wo.WorkOrderNo.Contains(search)
                                                                                                                                     select new
                                                                     {
                                      PartNo = pn.PartNo,
                                      wo.WorkOrderNo,
                                      wo.OutputQuantityPC,
                                      wo.Description,
                                      wo.Timestamp,
                                  }).ToList();
                    dgvPC.DataSource = listPC;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }

        public void LoadDataComboBox()
        {
            using (var context = new FPYEntities())
            {
                var partNos = context.Products.Select(p => p.PartNo).ToList();
                txtPartNo.DataSource = partNos;
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
                using (var db = new FPYEntities())
                {
                    var workOrder = db.WorkOrders.FirstOrDefault(p => p.WorkOrderNo == txtWO.Text);
                    if (workOrder != null)
                    {
                        var partNo = db.Products.FirstOrDefault(p => p.PartNo == txtPartNo.Text);
                        workOrder.PartNo = partNo.ProductID;
                        workOrder.WorkOrderNo = txtWO.Text;
                        workOrder.OutputQuantityPC = Convert.ToInt32(txtOutputQty.Text);
                        workOrder.Description = txtDescription.Text;
                        workOrder.Timestamp = DateTime.Now;
                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("Data has been updated successfully");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Data has not been updated");
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
    }
}
