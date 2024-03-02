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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        #region Function 
        
        #endregion
        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            //get username
            lblUserName.Text = GlobalSettings.GetUserName();

        }
    }
}
