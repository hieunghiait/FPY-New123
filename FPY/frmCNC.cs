using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FPY
{
    public partial class frmCNC : Form
    {
        public frmCNC()
        {
            InitializeComponent();  
            this.Text = "FORM CNC";
        }
        #region Function

        public void LoadData()
        {
            using (var db = new FPYEntities())
            {
                try
                {
                    var data = (from cnc in db.CNCOperations
                                join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                join p in db.Products on wo.PartNo equals p.ProductID
                                select new
                                {
                                    p.PartNo,
                                    wo.WorkOrderNo,
                                    cnc.InputQuantityCNC,
                                    cnc.OutputQuantityCNC,
                                    cnc.DMRCNC,
                                    cnc.Timestamp
                                }).ToList();
                    dgvCNC.DataSource = data;
                    //select first row 
                    dgvCNC.Rows[0].Selected = true;
                    //Bindig first data to text box 
                    BindFirstRowToInputs(); 

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BindFirstRowToInputs()
        {
            if (dgvCNC.Rows.Count > 0)
            {
                var row = dgvCNC.Rows[0];
                txtPartNo.Text = Convert.ToString(row.Cells["PartNo"].Value);
                txtWO.Text = Convert.ToString(row.Cells["WorkOrderNo"].Value);
                txtInputQtyCNC.Text = Convert.ToString(row.Cells["InputQuantityCNC"].Value);
                txtOutputQtyCNC.Text = Convert.ToString(row.Cells["OutputQuantityCNC"].Value);
            }
        }

        #endregion

        #region Event
        private void frmCNC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new FPYEntities())
            {
                try
                {
                    var data = (from cnc in db.CNCOperations 
                                join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                join p in db.Products on wo.PartNo equals p.ProductID
                                where p.PartNo.Contains(txtWO.Text)
                                select new
                                {
                                    p.PartNo,
                                    wo.WorkOrderNo,
                                    cnc.InputQuantityCNC,
                                    cnc.OutputQuantityCNC,
                                    cnc.DMRCNC,
                                    cnc.Timestamp
                                }).ToList();
                    dgvCNC.DataSource = data;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    try
                    {
                        var workOrderNo = txtWO.Text.Trim();
                       
                        var txtDRM = txtDMR.Text.Trim();
                        var cncData = db.CNCOperations.FirstOrDefault(c => c.WorkOrder.WorkOrderNo == workOrderNo);

                        if (cncData != null)
                        {
                            cncData.OutputQuantityCNC = int.Parse(txtOutputQtyCNC.Text.Trim());
                            cncData.DMRCNC = int.Parse(txtDRM);
                            cncData.Timestamp = DateTime.Now; //Cập nhật thời gian 
                            var detailingData = db.Detailings.FirstOrDefault(d => d.CNCOperationID == cncData.CNCOperationID);
                            //Nếu bảng Detailing tồn tại thì cập nhật giá trị hiện có
                            if (detailingData != null)
                            {
                                // Cập nhật giá trị hiện có nếu tìm thấy
                                detailingData.InputQuantityDetail = cncData.OutputQuantityCNC;
                                if(txtDRM == null)
                                {
                                    //Nếu không có giá trị DMR thì gán giá trị mặc định rỗng 
                                    detailingData.DMRDetail = null;
                                }    
                                detailingData.Timestamp = DateTime.Now; // Cập nhật thời gian nếu cần
                            }
                            // Thêm vào bản ghi mới nếu không tìm thấy bản ghi Detailing tương ứng
                            else
                            {
                                var newDetailing = new Detailing()
                                {
                                    InputQuantityDetail = cncData.OutputQuantityCNC,
                                    CNCOperationID = cncData.CNCOperationID,
                                    Timestamp = DateTime.Now
                                };
                                db.Detailings.Add(newDetailing);
                            }

                            if (db.SaveChanges() > 0)
                            {
                                MessageBox.Show("Update data successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Update data failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Work order not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCNC_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
          
           
        }
       
        private void textBoxDMR_TextChanged(object sender, EventArgs e)
        {
            //Chỉ cho phép nhập số  bao gồm số nguyên âm 
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDMR.Text, "[^0-9-]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtDMR.Text = txtDMR.Text.Remove(txtDMR.Text.Length - 1);
            }
           
        }

        private void txtBoxInputQuantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxWO_TextChanged(object sender, EventArgs e)
        {
            /*var workOrderNo = txtWO.Text.Trim();
            //search text change 
            using (var db = new FPYEntities())
            {
                try
                {
                    var data = (from cnc in db.CNCOperations
                                join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                join p in db.Products on wo.PartNo equals p.ProductID
                                where wo.WorkOrderNo.Contains(workOrderNo)
                                select new                                                                                                                            {
                                    p.PartNo,
                                    wo.WorkOrderNo,
                                    cnc.InputQuantityCNC,
                                    cnc.OutputQuantityCNC,
                                    cnc.DMRCNC,
                                    cnc.Timestamp
                                }).ToList();
                    dgvCNC.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }

        private void textBoxOutputQuantity_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtBoxInputQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBoxOutputQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnCalDMR_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvCNC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        //Delete data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var workOrderNo = txtWO.Text.Trim();
                    var cncData = db.CNCOperations.FirstOrDefault(c => c.WorkOrder.WorkOrderNo == workOrderNo);
                    if (cncData != null)
                    {
                        db.CNCOperations.Remove(cncData);
                        var detailingData = db.Detailings.FirstOrDefault(d => d.CNCOperationID == cncData.CNCOperationID);
                        if (detailingData != null)
                        {
                            db.Detailings.Remove(detailingData);
                        }
                        if (db.SaveChanges() > 0)
                        {
                           //Create data successfully
                           MessageBox.Show("Xóa dữ liệu thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa dữ liệu thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy work order");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxPartNum_TextChanged(object sender, EventArgs e)
        {
           /* using (var db = new FPYEntities())
            {
                try
                {
                    var data = (from cnc in db.CNCOperations
                                join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                join p in db.Products on wo.PartNo equals p.ProductID
                                where p.PartNo.Contains(txtPartNo.Text)
                                select new
                                {
                                    p.PartNo,
                                    wo.WorkOrderNo,
                                    cnc.InputQuantityCNC,
                                    cnc.OutputQuantityCNC,
                                    cnc.DMRCNC,
                                    cnc.Timestamp
                                }).ToList();
                    dgvCNC.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
          */
        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {
           LoadData();  
            MessageBox.Show("Reload data successfully");    
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show(); 
        }
        #endregion

        private void dgvCNC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            try
            {
                if (dgvCNC.Rows.Count > 0)
                {
                    var row = dgvCNC.Rows[e.RowIndex];
                    txtPartNo.Text = Convert.ToString(row.Cells["PartNo"].Value ?? "");
                    txtWO.Text = Convert.ToString(row.Cells["WorkOrderNo"].Value ?? "");
                    txtOutputQtyCNC.Text = Convert.ToString(row.Cells["OutputQuantityCNC"].Value ?? "");
                    txtDMR.Text = Convert.ToString(row.Cells["DMRCNC"].Value ?? "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using(var db = new FPYEntities())
                {

                    var data = (from cnc in db.CNCOperations
                                join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                join p in db.Products on wo.PartNo equals p.ProductID
                                select new
                                {
                                    p.PartNo,
                                    wo.WorkOrderNo,
                                    cnc.InputQuantityCNC,
                                    cnc.OutputQuantityCNC,
                                    cnc.DMRCNC,
                                    cnc.Timestamp
                                }).ToList();
                    dgvCNC.DataSource = data;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel.Worksheet ws = null;

                        ws = wb.Sheets["Sheet1"];
                        ws = wb.ActiveSheet;
                        ws.Name = "CNCOperations";

                        //Bôi đậm header 
                        ws.Rows[1].Font.Bold = true;

                        for (int i = 1; i < dgvCNC.Columns.Count + 1; i++)
                        {
                            ws.Cells[1, i] = dgvCNC.Columns[i - 1].HeaderText;
                        }

                        for (int i = 0; i < dgvCNC.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvCNC.Columns.Count; j++)
                            {
                                var value = dgvCNC.Rows[i].Cells[j].Value;
                                ws.Cells[i + 2, j + 1] = value == null ? "" : value.ToString();
                            }
                        }

                        wb.SaveAs(sfd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        app.Quit();
                        MessageBox.Show("Export data successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
