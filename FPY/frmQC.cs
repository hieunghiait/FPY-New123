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
    public partial class frmQC : Form
    {
        public frmQC()
        {
            InitializeComponent();
            this.Text = "FORM QC";
        }

        #region Function 
        //Function to load data from database to datagridview
        public void LoadData()
        {
            using (var db = new FPYEntities())
            {
                var data = from qc in db.QualityControls join detail in db.Detailings on qc.DetailingID equals detail.DetailingID 
                           join cnc in db.CNCOperations on detail.CNCOperationID equals cnc.CNCOperationID 
                           join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                           join p in db.Products on wo.PartNo equals p.ProductID
                           select new
                           {
                               qc.QCOperationID,
                               p.PartNo,
                               wo.WorkOrderNo,  
                               qc.InputQuantityQC, 
                               qc.OutputQuantityQC,
                               qc.DMRQC, 
                               qc.Timestamp
                            };
                dgvQC.DataSource = data.ToList();
                dgvQC.Refresh();
            }
        }
        #endregion
        #region Event
        private void frmQC_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
        #endregion
        #region Event 
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new FPYEntities())
            {
                try
                {
                    QualityControl qc = new QualityControl();
                    qc.QCOperationID = Convert.ToInt32(txtQCID.Text);
                    qc.InputQuantityQC = Convert.ToInt32(txtInputQtyQC.Text);
                    qc.OutputQuantityQC = Convert.ToInt32(txtOutputQtyQC.Text);
                    qc.DMRQC = Convert.ToInt32(txtDRMQC.Text);
                    db.QualityControls.Add(qc);
                    db.SaveChanges();
                    LoadData();
                }catch(Exception ex)
                {
                       MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
                try
                {
                    using (var db = new FPYEntities())
                    {
                        var data = from qc in db.QualityControls
                                   join detail in db.Detailings on qc.DetailingID equals detail.DetailingID
                                   join cnc in db.CNCOperations on detail.CNCOperationID equals cnc.CNCOperationID
                                   join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                                   join p in db.Products on wo.PartNo equals p.ProductID
                                   select new
                                   {
                                       qc.QCOperationID,
                                       p.PartNo,
                                       wo.WorkOrderNo,
                                       qc.InputQuantityQC,
                                       qc.OutputQuantityQC,
                                       qc.DMRQC,
                                       qc.Timestamp
                                   };
                        dgvQC.DataSource = data.ToList();
                        dgvQC.Refresh();
                        LoadData();
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
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new FPYEntities())
            {
                try
                {
                    int id = Convert.ToInt32(txtQCID.Text);
                    var qc = db.QualityControls.Where(x => x.QCOperationID == id).FirstOrDefault();
                    qc.OutputQuantityQC = Convert.ToInt32(txtOutputQtyQC.Text);
                    qc.DMRQC = Convert.ToInt32(txtDRMQC.Text);
                    qc.Timestamp = DateTime.Now;    
                    if(db.SaveChanges() > 0)
                    {
                           MessageBox.Show("Updated successfully");
                    }else
                    {
                        MessageBox.Show("Update failed");   
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvQC_Click(object sender, EventArgs e)
        {

        }

        private void dgvQC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQC.Rows[e.RowIndex];
                txtQCID.Text = row.Cells["QCOperationID"].Value != null ? row.Cells["QCOperationID"].Value.ToString() : "";
                txtPartNo.Text = row.Cells["PartNo"].Value != null ? row.Cells["PartNo"].Value.ToString() : "";
                txtWO.Text = row.Cells["WorkOrderNo"].Value != null ? row.Cells["WorkOrderNo"].Value.ToString() : "";
                txtInputQtyQC.Text = row.Cells["InputQuantityQC"].Value != null ? row.Cells["InputQuantityQC"].Value.ToString() : "";
                txtOutputQtyQC.Text = row.Cells["OutputQuantityQC"].Value != null ? row.Cells["OutputQuantityQC"].Value.ToString() : "";
                txtDRMQC.Text = row.Cells["DMRQC"].Value != null ? row.Cells["DMRQC"].Value.ToString() : "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    try
                    {
                        int id = Convert.ToInt32(txtQCID.Text);
                        var qc = db.QualityControls.Where(x => x.QCOperationID == id).FirstOrDefault();
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            db.QualityControls.Remove(qc);
                            db.SaveChanges();
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPartNoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var search = txtPartNoSearch.Text;
                    if (search == string.Empty)
                    {
                        LoadData();
                    }
                    var data = from qc in db.QualityControls
                               join detail in db.Detailings on qc.DetailingID equals detail.DetailingID
                               join cnc in db.CNCOperations on detail.CNCOperationID equals cnc.CNCOperationID
                               join wo in db.WorkOrders on cnc.WorkOrderID equals wo.WorkOrderID
                               join p in db.Products on wo.PartNo equals p.ProductID
                               where p.PartNo.Contains(search)
                               select new
                               {
                                   qc.QCOperationID,
                                   p.PartNo,
                                   wo.WorkOrderNo,
                                   qc.InputQuantityQC,
                                   qc.OutputQuantityQC,
                                   qc.DMRQC,
                                   qc.Timestamp
                               };
                    dgvQC.DataSource = data.ToList();
                    dgvQC.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReloadData_Click(object sender, EventArgs e)
        {
            LoadData(); 
            MessageBox.Show("Data reloaded successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
