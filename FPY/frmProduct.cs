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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
        public void LoadData()
        {
            using (var db = new FPYEntities())
            {
                try
                {
                    var products = db.Products.Select(p => new
                    {
                        p.PartNo,
                    }).ToList();
                    dgvProducts.DataSource = products;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvProducts.CurrentRow.Selected = true;
                    txtPartNo.Text = dgvProducts.Rows[e.RowIndex].Cells["PartNo"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void validationProduct()
        {
            if (string.IsNullOrEmpty(txtPartNo.Text))
            {
                MessageBox.Show("Part No is required");
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string partNo = txtPartNo.Text;
            try
            {
                validationProduct();
                using (var db = new FPYEntities())
                {
                    var product = new Product
                    {
                        PartNo = partNo
                    };
                    db.Products.Add(product);
                    if(db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Product added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Product not added");
                    } 
                    db.SaveChanges();
                    LoadData();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Edit product in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                validationProduct();
                //update 
                using (var db = new FPYEntities())
                {
                    var product = db.Products.FirstOrDefault(p => p.PartNo == txtPartNo.Text);
                    if (product != null)
                    {
                        product.PartNo = txtPartNo.Text;
                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("Product updated successfully");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Product not updated");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    // Chuyển đổi txtPartNo.Text sang kiểu int trước khi sử dụng trong truy vấn
                    

                    var product = db.Products.FirstOrDefault(p => p.PartNo == txtPartNo.Text);
                    if (product != null)
                    {
                        db.Products.Remove(product);
                        if (db.SaveChanges() > 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                MessageBox.Show("Product deleted successfully");
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                return;
                            }
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Product not deleted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var search = txtSearch.Text;
                    if(search == string.Empty)
                    {
                        LoadData();
                    }
                    var products = db.Products.Where(p => p.PartNo.Contains(search)).Select(p => new
                    {
                        p.PartNo,
                    }).ToList();
                    dgvProducts.DataSource = products;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_Validated(object sender, EventArgs e)
        {

        }
    }
}
