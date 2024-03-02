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
            AddRowNumberColumn(); 
            this.dgvCNC.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dgvCNC_RowPostPaint);
            //set title 
            this.Text = "FORM CNC";
        }
        public  void LoadData()
        {
            using (var db = new FPYEntities())
            {
                try
                { 
                    var data = 
                                ( from cnc in db.CNCOperations
                                join wo in db.WorkOrders
                                on cnc.WorkOrderID equals wo.WorkOrderID
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void AddRowNumberColumn()
        {

        }
        private void dgvCNC_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

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
                                where p.PartNo.Contains(txtBoxWO.Text)
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
                        var workOrderNo = txtBoxWO.Text;
                        var cncData = db.CNCOperations.FirstOrDefault(c => c.WorkOrder.WorkOrderNo == workOrderNo);
                        if (cncData != null)
                        {
                            cncData.OutputQuantityCNC = int.Parse(textBoxOutputQuantity.Text); // Cập nhật giá trị Output Quantity
                            cncData.DMRCNC = int.Parse(textBoxDMR.Text);
                            cncData.Timestamp = DateTime.Now; //Cập nhật thời gian 
                                                              // Tìm bản ghi Detailing hiện có liên quan
                            var detailingData = db.Detailings.FirstOrDefault(d => d.CNCOperationID == cncData.CNCOperationID);
                            //Nếu bảng Detailing tồn tại thì cập nhật giá trị hiện có
                            if (detailingData != null)
                            {
                                // Cập nhật giá trị hiện có nếu tìm thấy
                                detailingData.InputQuantityDetail = cncData.OutputQuantityCNC;
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
                                MessageBox.Show("Cập nhật dữ liệu thành công");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật dữ liệu thất bại");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Work order not found");
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Please enter valid numbers for Output Quantity and DMR.");
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
            try
            {
                if (dgvCNC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCNC.CurrentRow.Selected = true;
                    //txtBoxWO.Text = dgvCNC.Rows[e.RowIndex].Cells["WO"].FormattedValue.ToString();
                    txtBoxInputQuantity.Text = dgvCNC.Rows[e.RowIndex].Cells["InputQuantityCNC"].FormattedValue.ToString();
                    textBoxOutputQuantity.Text = dgvCNC.Rows[e.RowIndex].Cells["OutputQuantityCNC"].FormattedValue.ToString();
                    textBoxDMR.Text = dgvCNC.Rows[e.RowIndex].Cells["DMRCNC"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
          
           
        }
       
        private void textBoxDMR_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtBoxInputQuantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxWO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutputQuantity_TextChanged(object sender, EventArgs e)
        {
            //chỉ cho phép nhập số 
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxOutputQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxOutputQuantity.Text = textBoxOutputQuantity.Text.Remove(textBoxOutputQuantity.Text.Length - 1);
            }
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
            try
            {
                if (dgvCNC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvCNC.CurrentRow.Selected = true;
                    textBoxPartNum .Text = dgvCNC.Rows[e.RowIndex].Cells["PartNo"].FormattedValue.ToString();
                    txtBoxWO.Text = dgvCNC.Rows[e.RowIndex].Cells["WorkOrderNo"].FormattedValue.ToString();
                    txtBoxInputQuantity.Text = dgvCNC.Rows[e.RowIndex].Cells["InputQuantityCNC"].FormattedValue.ToString();
                    textBoxOutputQuantity.Text = dgvCNC.Rows[e.RowIndex].Cells["OutputQuantityCNC"].FormattedValue.ToString();
                    textBoxDMR.Text = dgvCNC.Rows[e.RowIndex].Cells["DMRCNC"].FormattedValue.ToString();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var workOrderNo = txtBoxWO.Text;
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
                            MessageBox.Show("Xóa dữ liệu thành công");
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
    }
}
