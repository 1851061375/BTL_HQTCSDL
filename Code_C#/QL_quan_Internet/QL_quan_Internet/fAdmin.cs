using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_quan_Internet.DAO;

namespace QL_quan_Internet
{
    public partial class fAdmin : Form
    {
        BindingSource accountList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            CultureInfo culture = new CultureInfo("vi-VN");
            LoadListBillByDate(dt_revenue.Value);
            lb_totalrevenue.Text = BillDAO.Instance.GetTotalRevenueByDate(dt_revenue.Value).ToString("c", culture);
            LoadListAccount();
            dtgv_account.DataSource = accountList;
            BindingAccount();
        }
        #region methods
        void LoadListBillByDate(DateTime date)
        {
            dtgv_revenue.DataSource = BillDAO.Instance.GetListBillByDate(date);
        }

        void LoadListAccount()
        {
            accountList.DataSource = AccountDAO.Instance.LoadListAccount();
        }

        void LoadTypeAccount()
        {
            cb_accounttype.DataSource = AccountTypeDAO.Instance.GetAccountType();
            cb_accounttype.DisplayMember = "Name";
        }

        void BindingAccount()
        {
            tb_username.DataBindings.Add(new Binding("Text", dtgv_account.DataSource, "Tên người dùng",true,DataSourceUpdateMode.Never));
            tb_displayname.DataBindings.Add(new Binding("Text", dtgv_account.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            cb_accounttype.DataBindings.Add(new Binding("Text", dtgv_account.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never));
        }


        #endregion

        #region events
        private void bt_static_Click(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            LoadListBillByDate(dt_revenue.Value);
            lb_totalrevenue.Text = BillDAO.Instance.GetTotalRevenueByDate(dt_revenue.Value).ToString("c",culture);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_displayname.Text == "" )
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int type = 0;
                if (cb_accounttype.Text == "admin") type = 1;
                try
                {
                    AccountDAO.Instance.InsertAccount(tb_username.Text, tb_displayname.Text, type);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tên người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadListAccount();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_displayname.Text == "")
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int type = 0;
                if (cb_accounttype.Text == "admin") type = 1;
                try
                {
                    AccountDAO.Instance.UpdateAccount(tb_username.Text, tb_displayname.Text, type,dtgv_account.SelectedCells[0].Value.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Tên người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadListAccount();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.DeleteAccount(dtgv_account.SelectedCells[0].Value.ToString()) == false)
                MessageBox.Show("Không được xóa tài khoản admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadListAccount();
        }


        #endregion

        /*private void bt_update_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (cb_typeaccount.Text == "admin") type = 1;
            AccountDAO.Instance.UpdateAccount(tb_username.Text, tb_displayname.Text, tb_password.Text, type, dtgv_account.SelectedCells[0].Value.ToString());
            LoadListAccount();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (cb_typeaccount.Text == "admin") type = 1;
            AccountDAO.Instance.InsertAccount(tb_username.Text, tb_displayname.Text, tb_password.Text, type);
            LoadListAccount();
        }*/
    }
}
