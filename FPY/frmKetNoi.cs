using FPY.Properties;
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
    public partial class frmKetNoi : Form
    {
        private string connectionString;
        public frmKetNoi()
        {
            InitializeComponent();
        }

        #region Function
        public void LoadKieuXacThuc()
        {
            cboKieuXacThuc.Items.Add("Windows Authentication");
            cboKieuXacThuc.Items.Add("SQL Server Authentication");
            cboKieuXacThuc.SelectedIndex = 0;
        }
        public static List<string> getDanhSachDatabase()
        {
            using (var db = new FPYEntities())
            {
                return db.Database.SqlQuery<string>("SELECT name FROM sys.databases").ToList();
            }
        }
        #endregion
        #region Event
        private void frmKetNoi_Load(object sender, EventArgs e)
        {
            LoadKieuXacThuc();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenServer.Text))
                    throw new ArgumentException("Tên đăng nhập không được trống");

                connectionString = string.Format("Data Source={0};Initial Catalog=master;", txtTenServer.Text);

                if (cboKieuXacThuc.SelectedIndex == 0)
                    connectionString += "Integrated Security=True;"; //Xác thực Windows (tài khoản máy tính)
                else
                    connectionString += string.Format("User Id={0};Password={1};", txtTenDangNhap.Text, txtMatKhau.Text); //Xác thực SQL Server bao gồm tên đăng nhập và mật khẩu
                //Lấy danh sách database từ server
                cboDatabase.DataSource = GlobalSettings.GetDatabaseList(connectionString);
                MessageBox.Show("Kết nối thành công!" + Environment.NewLine + "Vui lòng chọn cơ sở dữ liệu trong danh sách bên dưới.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboDatabase.Enabled = true;
                btnLuuThongTin.Enabled = true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại!" + Environment.NewLine + "Vui lòng thử lại một lần nữa.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            connectionString = string.Format("Data Source = {0}; Initial Catalog = {1}; ", txtTenServer.Text, cboDatabase.Text);

            if (cboKieuXacThuc.SelectedIndex == 0)
                connectionString += "Integrated Security = True; ";
            else
                connectionString += string.Format("User Id = {0}; Password = {1}; ", txtTenDangNhap.Text, txtMatKhau.Text);
            //Lưu thông tin kết nối
            GlobalSettings.ConnectionString = connectionString;
            GlobalSettings.ServerName = txtTenServer.Text;
            GlobalSettings.ServerCatalog = cboDatabase.Text;

            GlobalSettings.SaveDatabaseConnection();

            MessageBox.Show("Đã lưu cài đặt kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cboKieuXacThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = txtMatKhau.Enabled = cboKieuXacThuc.SelectedIndex == 1;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}