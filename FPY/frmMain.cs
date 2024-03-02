using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPY
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            //Đóng form hiện tại 
            this.Hide();
            frmPC frmPC = new frmPC();
            frmPC.Show();
        }

        private void btnOpenCNC_Click(object sender, EventArgs e)
        {
            this.Hide();    
            frmCNC frm = new frmCNC();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenDetail_Click(object sender, EventArgs e)
        {
            //Ẩn form hiện tại 
            this.Hide();
            //Tạo mới form Detail
            frmDetail frmDetail = new frmDetail(); 
            //Hiển thị form Detail
            frmDetail.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                frmLOGIN frm = new frmLOGIN();
                frm.Show();
            }
        }

        private void btnOpenQC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQC frmQC = new frmQC();
            frmQC.Show(); 


        }
    }
}
