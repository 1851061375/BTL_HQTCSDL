using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_quan_Internet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAP\SQLEXPRESS;Initial Catalog=QL_quan_Internet;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = tb_taikhoan.Text;
                string mk = tb_matkhau.Text;
                string sql = "select* from NguoiDung where TaiKhoan = '"+tk+"' and MatKhau = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
                Application.Exit();
        }
    }
}
