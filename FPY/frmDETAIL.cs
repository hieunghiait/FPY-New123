using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPY
{
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
            LoadData();
        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDetail.CurrentRow.Selected = true;
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
        public void LoadDataDetail()
        {
           
        }
        private void frmDetail_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            using (var db = new FPYEntities())
            {
                try
                {
                    var data = 
                        (
                        from detail in db.Detailings 
                        join cncs in db.CNCOperations on detail.CNCOperationID 
                        equals cncs.CNCOperationID
                        from cnc in db.CNCOperations
                        join wo in db.WorkOrders
                        on cnc.WorkOrderID equals wo.WorkOrderID
                        join p in db.Products on wo.PartNo equals p.ProductID
                        select new
                        {
                            p.PartNo,
                            wo.WorkOrderNo, 
                            detail.InputQuantityDetail, 
                            detail.OutputQuantityDetail,
                            detail.DMRDetail,
                            cnc.Timestamp
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
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
