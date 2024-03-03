using FPY.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FPY
{
    public partial class frmLOGIN : Form
    {
        public frmLOGIN()
        {
            InitializeComponent();
        }
        
        #region Function
        public bool isValidLogin(string username, string password)
        {
                try
            {
                using (var db = new FPYEntities())
                {
                    //Kiểm tra userName có tồn tại trong database không 
                    var user = db.Users.FirstOrDefault(u => u.Username == username);
                    if (user != null)
                    {
                        //Kiểm tra mật khẩu 
                        var passWord = db.Users.FirstOrDefault(u => u.Password == password);
                        if (passWord != null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void checkHistoryLogin(string username, string password)
        {
            if (chkSave.Checked)
            {
                //Lưu thông tin đăng nhập
                Settings.Default.Login_UserName = username;
                Settings.Default.Login_Password = password;
                Settings.Default.Save();
            }
            else
            {
                //Xóa thông tin đăng nhập đã lưu
                Settings.Default.Login_UserName = string.Empty;
                Settings.Default.Login_Password = string.Empty;
                Settings.Default.Save();
            }
        }
        #endregion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text; 
            if(isValidLogin(username, password))
            {
                ///Kiểm tra xem người dùng có chọn lưu thông tin đăng nhập không
                checkHistoryLogin(username, password);
                MessageBox.Show("Login successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Ẩn form hiện tại và hiển thị form chính
                this.Hide();
                frmMain frmMain = new frmMain(); 
                frmMain.Show();
            }
            else
            {
                lblNotification.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmREGISTER frmRegister = new frmREGISTER();
            frmRegister.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkSave_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Login_IsSaved = chkSave.Checked;
            Settings.Default.Save();
        }

        private void frmLOGIN_Load(object sender, EventArgs e)
        {
            chkSave.Checked = Settings.Default.Login_IsSaved;
            if (chkSave.Checked)
            {

                txtUsername.Text = Settings.Default.Login_UserName;
                txtPassword.Text = Settings.Default.Login_Password;
            }

            lblNotification.Text = string.Empty;
        }
    }
}
