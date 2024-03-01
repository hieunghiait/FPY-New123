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
        private string hashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = string.Concat(password, salt);
                var saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);
                var hashBytes = sha256.ComputeHash(saltedPasswordBytes);

                return Convert.ToBase64String(hashBytes);
            }
        }
        #endregion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text; 
            if(isValidLogin(userName, passWord))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                frmMain frmMain = new frmMain(); 
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmREGISTER frmRegister = new frmREGISTER();
            frmRegister.Show();
        }
    }
}
