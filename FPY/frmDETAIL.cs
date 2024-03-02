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
        public void LoadDataDetail()
        {
           
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
                                    PartNo = p.ProductID, // Assuming PartNo is the same as ProductID
                                    wo.WorkOrderNo,
                                    detail.InputQuantityDetail,
                                    detail.OutputQuantityDetail,
                                    detail.DMRDetail,
                                    detail.Timestamp
                                }).ToList();

                    dgvDetail.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
                    
                    var partNo = txtPartNo.Text;
                    var workOrderNo = txtWO.Text;

                    if (detail == null)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu");
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

                    // Update Detailing
                    detail.OutputQuantityDetail = outputQtyDetail;
                    detail.DMRDetail = dmrDetail;
                    detail.Timestamp = currentTime;

                    
                    var confirmation = MessageBox.Show("Bạn có chắc chắn muốn cập nhật ? " + partNo + " với " + workOrderNo, " Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Proceed if user confirms
                    if (confirmation == DialogResult.Yes)
                    {
                        // Update QualityControl or create new one
                        var qc = db.QualityControls.FirstOrDefault(x => x.DetailingID == detailId);

                        if (qc != null)
                        {
                            qc.InputQuantityQC = outputQtyDetail;
                            qc.DMRQC = dmrDetail;
                            qc.Timestamp = currentTime;
                        }
                        else
                        {
                            // Create new QualityControl
                            var newQC = new QualityControl
                            {
                                DetailingID = detailId,
                                InputQuantityQC = outputQtyDetail,
                                DMRQC = dmrDetail,
                                Timestamp = currentTime
                            };
                            db.QualityControls.Add(newQC);
                        }

                        // Save changes to the database
                        db.SaveChanges();

                        // Display success message with DialogResult
                        var result = MessageBox.Show("Cập nhật thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    txtDetailID.Text = dgvDetail.Rows[e.RowIndex].Cells["DetailingID"].FormattedValue.ToString();
                    txtPartNo.Text = dgvDetail.Rows[e.RowIndex].Cells["PartNo"].FormattedValue.ToString();
                    txtWO.Text = dgvDetail.Rows[e.RowIndex].Cells["WorkOrderNo"].FormattedValue.ToString();
                    txtInputQtyDetail.Text = dgvDetail.Rows[e.RowIndex].Cells["InputQuantityDetail"].FormattedValue.ToString();
                    txtOutputQtyDetail.Text = dgvDetail.Rows[e.RowIndex].Cells["OutputQuantityDetail"].FormattedValue.ToString();
                    txtDescriptionDetail.Text = dgvDetail.Rows[e.RowIndex].Cells["DMRDetail"].FormattedValue.ToString();
                    txtDMRDetail.Text = dgvDetail.Rows[e.RowIndex].Cells["DMRDetail"].FormattedValue.ToString();
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
                        MessageBox.Show("Không tìm thấy dữ liệu");
                        return;
                    }

                    var confirmation = MessageBox.Show("Bạn có chắc chắn muốn xóa " + detailId, " Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        db.Detailings.Remove(detail);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công");
                        LoadData();
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
