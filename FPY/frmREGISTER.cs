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
    public partial class frmREGISTER : Form
    {
        public frmREGISTER()
        {
            InitializeComponent();
        }

        private void frmREGISTER_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
        #region Function 
        /// <summary>
        /// Hàm kiểm tra username đã tồn tại trong database chưa 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool isCheckUsername(string userName)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    var user = db.Users.FirstOrDefault(u => u.Username == userName);
                    if (user != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool ValidationInput(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập username");
                txtUsername.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập password");
                txtPassword.Focus();
                return false;
            }
            return true; 
        }
        public void OpenFormLogin()
        {
            this.Hide();
            frmLOGIN frmLogin = new frmLOGIN();
            frmLogin.ShowDialog();
        }
        public void handleRegister(string username, string password)
        {
            try
            {
                using (var db = new FPYEntities())
                {
                    User user = new User();
                    user.Username = username;
                    user.Password = password;
                    user.RoleID = 1; // 1 là user, 2 là admin
                    user.CreateDate = DateTime.Now;
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Register successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenFormLogin();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
        #endregion 
        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLOGIN frmLogin = new frmLOGIN();
            frmLogin.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string passWord = txtPassword.Text.Trim();
            if (ValidationInput(userName, passWord))
            {
                if (isCheckUsername(userName))
                {
                    MessageBox.Show("Username đã tồn tại trong CSDL, Xin vui lòng chọn username khác", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }
                handleRegister(userName, passWord);
            }
           
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
