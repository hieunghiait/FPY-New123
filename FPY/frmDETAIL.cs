using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FPY
{
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
            //set title 
            this.Text = "FORM DETAIL"; 
        }
        
        private void frmDetail_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data for the first time
        }

        public void LoadData()
        {
            using (var db = new FPYEntities())
            {
                try
                {
                    var data = (from detail in db.Detailings
                                join cnc in db.CNCOperations on detail.CNCOperationID equals cnc.CNCOperationID
                                join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                join p in db.Products on wo.PartNo equals p.ProductID
                                select new
                                {
                                    detail.DetailingID,
                                    p.PartNo,
                                    wo.WorkOrderNo,
                                    detail.InputQuantityDetail,
                                    detail.OutputQuantityDetail,
                                    detail.DMRDetail,
                                    detail.Timestamp
                                }).ToList();    
                    dgvDetail.DataSource = data;
                    dgvDetail.Rows[0].Selected = true;
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
            if (dgvDetail.Rows.Count > 0)
            {
                txtDetailID.Text = dgvDetail.Rows[0].Cells["DetailingID"].FormattedValue.ToString() ?? "";
                txtPartNo.Text = dgvDetail.Rows[0].Cells["PartNo"].FormattedValue.ToString() ?? "";
                txtWO.Text = dgvDetail.Rows[0].Cells["WorkOrderNo"].FormattedValue.ToString() ?? "";
                txtInputQtyDetail.Text = dgvDetail.Rows[0].Cells["InputQuantityDetail"].FormattedValue.ToString() ?? "";
                txtOutputQtyDetail.Text = dgvDetail.Rows[0].Cells["OutputQuantityDetail"].FormattedValue.ToString() ?? "";
                txtDescriptionDetail.Text = dgvDetail.Rows[0].Cells["DMRDetail"].FormattedValue.ToString() ?? "";
                txtDMRDetail.Text = dgvDetail.Rows[0].Cells["DMRDetail"].FormattedValue.ToString() ?? "";
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (var db = new FPYEntities())
            {
                try
                {
                    var detailId = int.Parse(txtDetailID.Text);
                    var detail = db.Detailings.Find(detailId);
                    
                    var partNo = txtPartNo.Text.Trim();
                    var workOrderNo = txtWO.Text.Trim();

                    if (detail == null)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var outputQtyDetail = int.Parse(txtOutputQtyDetail.Text);

                    // Check and parse DMR input
                    int dmrDetail;
                    if (!int.TryParse(txtDMRDetail.Text, out dmrDetail))
                    {
                        dmrDetail = 0; // Default DMR to 0 if not provided or invalid
                    }
                    var currentTime = DateTime.Now;
                    detail.OutputQuantityDetail = outputQtyDetail;
                    detail.DMRDetail = dmrDetail;
                    detail.Timestamp = currentTime;
                    var confirmation = MessageBox.Show("Bạn có chắc chắn muốn cập nhật ? " + partNo + " với " + workOrderNo, " Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        // Update QualityControl or create new one
                        var qc = db.QualityControls.FirstOrDefault(x => x.DetailingID == detailId);

                        if (qc != null)
                        {
                            qc.InputQuantityQC = outputQtyDetail;
                            qc.Timestamp = currentTime;
                        }
                        else
                        {
                            // Create new QualityControl
                            var newQC = new QualityControl
                            {
                                DetailingID = detailId,
                                InputQuantityQC = outputQtyDetail,
                                Timestamp = currentTime
                            };
                            db.QualityControls.Add(newQC);
                        }
                        // Save changes to the database
                        db.SaveChanges();

                        // Display success message with DialogResult
                        var result = MessageBox.Show("Cập nhật thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        // If user clicks OK, refresh the DataGridView
                        if (result == DialogResult.OK)
                        {
                            dgvDetail.Refresh(); // Refresh lại dữ liệu
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDetail.CurrentRow.Selected = true;
                    txtDetailID.Text = dgvDetail.Rows[e.RowIndex].Cells["DetailingID"].FormattedValue.ToString() ?? "";
                    txtPartNo.Text = dgvDetail.Rows[e.RowIndex].Cells["PartNo"].FormattedValue.ToString() ?? "";
                    txtWO.Text = dgvDetail.Rows[e.RowIndex].Cells["WorkOrderNo"].FormattedValue.ToString() ?? "";
                    txtInputQtyDetail.Text = dgvDetail.Rows[e.RowIndex].Cells["InputQuantityDetail"].FormattedValue.ToString() ?? "";
                    txtOutputQtyDetail.Text = dgvDetail.Rows[e.RowIndex].Cells["OutputQuantityDetail"].FormattedValue.ToString() ?? "";
                    txtDescriptionDetail.Text = dgvDetail.Rows[e.RowIndex].Cells["DMRDetail"].FormattedValue.ToString() ?? "";
                    txtDMRDetail.Text = dgvDetail.Rows[e.RowIndex].Cells["DMRDetail"].FormattedValue.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData(); 
            MessageBox.Show("Reload data successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var detailId = int.Parse(txtDetailID.Text);
                    var detail = db.Detailings.Find(detailId);

                    if (detail == null)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa " + detailId, " Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        db.Detailings.Remove(detail);
                        db.SaveChanges();
                        //Hiển thị thông báo xóa thành công 
                        MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtOutputQtyDetail_TextChanged(object sender, EventArgs e)
        {
            //cho phép nhập số 
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOutputQtyDetail.Text, "[^0-9]"))
            {
                //Hiển thị thông báo chỉ cho phép nhập số 
                MessageBox.Show("Chỉ cho phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                txtOutputQtyDetail.Text = txtOutputQtyDetail.Text.Remove(txtOutputQtyDetail.Text.Length - 1);
            }
        }

        private void txtDMRDetail_TextChanged(object sender, EventArgs e)
        {
            //cho phép nhập số 
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDMRDetail.Text, "[^0-9]"))
            {

                MessageBox.Show("Chỉ cho phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDMRDetail.Text = txtDMRDetail.Text.Remove(txtDMRDetail.Text.Length - 1);
            }
        }

        private void txtPartNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWO_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPartNoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var partNo = txtPartNoSearch.Text.Trim();
                    var data = (from detail in db.Detailings
                               join cnc in db.CNCOperations on detail.CNCOperationID equals cnc.CNCOperationID
                               join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                               join p in db.Products on wo.PartNo equals p.ProductID
                               select new
                               {
                                   detail.DetailingID,
                                   PartNo = p.ProductID, 
                                   wo.WorkOrderNo,
                                   detail.InputQuantityDetail,
                                   detail.OutputQuantityDetail,
                                   detail.DMRDetail,
                                   detail.Timestamp
                               }).ToList();
                    dgvDetail.DataSource = data;
                    dgvDetail.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtWOSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var workOrderNo = txtWOSearch.Text.Trim();
                    var data = (from detail in db.Detailings
                                join cnc in db.CNCOperations on detail.CNCOperationID equals cnc.CNCOperationID
                                join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                join p in db.Products on wo.PartNo equals p.ProductID
                                select new
                                {
                                    detail.DetailingID,
                                    PartNo = p.ProductID,
                                    wo.WorkOrderNo,
                                    detail.InputQuantityDetail,
                                    detail.OutputQuantityDetail,
                                    detail.DMRDetail,
                                    detail.Timestamp
                                }).ToList();
                    dgvDetail.DataSource = data;
                    dgvDetail.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
