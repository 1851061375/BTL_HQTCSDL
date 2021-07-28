using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_quan_Internet.DTO;
using QL_quan_Internet.DAO;
using System.Globalization;
using System.Threading;


namespace QL_quan_Internet
{
    public partial class fContain : Form
    {
        private Account loginAccount;
        public Account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value;}
        }
        public fContain(Account account)
        {
            InitializeComponent();

            this.loginAccount = account;
            ChangeAccount(loginAccount.Type);
            LoadComputer();
            LoadCategory();
            LoadAllFood();
        }

        #region methods
        void ChangeAccount(int type)
        {
            item_admin.Enabled = type == 1;
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            foreach (Category item in listCategory)
            {
                tv_menu.Nodes[0].Nodes.Add(item.CategoryName);
            }
        }

        void Load_FoodByCategory(string categoryName)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategory(categoryName);
            foreach (Food item in listFood)
            {
                ListViewItem lv_item = new ListViewItem(item.FoodName.ToString());
                lv_item.SubItems.Add(item.Unit.ToString());
                lv_item.SubItems.Add(item.Price.ToString());

                lv_menu.Items.Add(lv_item);
            }

        }

        void LoadAllFood()
        {
            List<Food> listFood = FoodDAO.Instance.GetAllFood();
            foreach (Food item in listFood)
            {
                ListViewItem lv_item = new ListViewItem(item.FoodName.ToString());
                lv_item.SubItems.Add(item.Unit.ToString());
                lv_item.SubItems.Add(item.Price.ToString());

                lv_menu.Items.Add(lv_item);
            }
        }

        private void LoadComputer()
        {
            List<Computer> computerList = ComputerDAO.Instance.LoadComputerList();
            fl_computer.Controls.Clear();
            foreach (Computer item in computerList)
            {
                Button btn = new Button() { Width = ComputerDAO.width_btn, Height = ComputerDAO.height_btn };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightSkyBlue;
                        break;
                    case "Có người":
                        btn.BackColor = Color.LightPink;
                        break;
                }
                fl_computer.Controls.Add(btn);
            }
        }

        private void Show_Bill_Infor(int id)
        {
            lv_billinfo.Items.Clear();
            List<Bill_Info> listBillInfor = Bill_InfoDAO.Instance.GetBillInfoByIDComputer(id);
            int drinkPrice = 0;
            if (listBillInfor.Count == 0)
            {
                tb_foodprice.Text = "0,00 ₫";
            }
            else
            {
                foreach (Bill_Info item in listBillInfor)
                {
                    CultureInfo culture = new CultureInfo("vi-VN");
                    //Thread.CurrentThread.CurrentCulture = culture;
                    //Note 
                    ListViewItem lv_item = new ListViewItem(item.FoodName.ToString());
                    lv_item.SubItems.Add(item.Quantity.ToString());
                    lv_item.SubItems.Add(item.Price.ToString());
                    //note
                    drinkPrice += item.Quantity*item.Price;
                    tb_foodprice.Text = drinkPrice.ToString("c",culture);

                    lv_billinfo.Items.Add(lv_item);
                }

            }

            lb_starthour.Text = BillDAO.Instance.GetStartHour(id);
            lb_startminute.Text = BillDAO.Instance.GetStartMinute(id);

            int idBill = BillDAO.Instance.GetUncheckBill(id);
            if (idBill != -1)
            {
                lb_finalhour.Text = DateTime.Now.ToString("HH");
                lb_finalminute.Text = DateTime.Now.ToString("mm");
            }
            else
            {
                lb_finalhour.Text = "00";
                lb_finalminute.Text = "00";
                tb_timeprice.Text = "0,00 ₫";
            }

        }
        #endregion

        #region events
        //get Category from treeview?
        string tmp_category;
        private void tv_menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lv_menu.Items.Clear();
            tmp_category = tv_menu.SelectedNode.Text;
            if (tmp_category == "Tất cả")
                LoadAllFood();
            Load_FoodByCategory(tmp_category);
        }

        //get foodName from listview Menu
        string add_foodName;
        private void lv_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                ListViewItem item = lv.SelectedItems[0];
                add_foodName = item.Text;
            }
        }

        //add food to bill
        private void bt_add_Click(object sender, EventArgs e)
        {
            Computer computer = lv_billinfo.Tag as Computer;
            if (computer != null)
            {
                int idBill = BillDAO.Instance.GetUncheckBill(computer.ID);
                int quantity = (int)n_quantity.Value;
                //add food to new computer
                if (idBill != -1 && add_foodName != null)
                {
                    Bill_InfoDAO.Instance.InsertBill_Info(idBill, add_foodName, quantity);
                    FoodDAO.Instance.DecreaseFood(add_foodName, quantity);
                }
                Show_Bill_Infor(computer.ID);
            }
        }

        string remove_foodName;
        private void lv_billinfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                ListViewItem item = lv.SelectedItems[0];
                remove_foodName = item.Text;
            }
        }

        private void bt_decrease_Click(object sender, EventArgs e)
        {
            Computer computer = lv_billinfo.Tag as Computer;
            if (computer != null)
            {
                //get idBill has status = 0 from idComputer
                int idBill = BillDAO.Instance.GetUncheckBill(computer.ID);
                int quantity = (int)n_quantity.Value;
                if (idBill != -1 && remove_foodName != null)
                {
                    Bill_InfoDAO.Instance.DecreaseFood(idBill, remove_foodName, quantity);
                    FoodDAO.Instance.AddFood(remove_foodName, quantity);
                }
                
                Show_Bill_Infor(computer.ID);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            Computer computer = lv_billinfo.Tag as Computer;
            if (computer != null && remove_foodName != null)
            {
                DialogResult thongbao = MessageBox.Show("Xóa món, bạn chắc chắn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (thongbao == DialogResult.OK)
                {
                    int idBill = BillDAO.Instance.GetUncheckBill(computer.ID);
                    Bill_InfoDAO.Instance.DeleteFood(idBill, remove_foodName);

                    ListViewItem item = lv_billinfo.SelectedItems[0];
                    int quantity = Convert.ToInt32(item.SubItems[1].Text);
                    FoodDAO.Instance.AddFood(remove_foodName,quantity);
                    remove_foodName = null;
                    Show_Bill_Infor(computer.ID);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //get id computer when click button
            int computerID = ((sender as Button).Tag as Computer).ID;
            lb_computername.Text = ((sender as Button).Tag as Computer).Name;

            Show_Bill_Infor(computerID);
            //save computer
            lv_billinfo.Tag = (sender as Button).Tag;

            timer2.Start();
        }

        private void item_admin_Click(object sender, EventArgs e)
        {
            fAdmin f_admin = new fAdmin();
            f_admin.ShowDialog();
        }

        private void item_khohang_Click(object sender, EventArgs e)
        {
            fStorage f_store = new fStorage();
            f_store.ShowDialog();
        }

        private void item_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
                this.Hide();

        }

        private void bt_start_Click(object sender, EventArgs e)
        {

            Computer computer = lv_billinfo.Tag as Computer;
            if (computer != null)
            {
                int idBill = BillDAO.Instance.GetUncheckBill(computer.ID);
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(computer.ID);
                    LoadComputer();
                    Show_Bill_Infor(computer.ID);
                    timer1.Start();
                }
            }
        }

        private void bt_final_Click(object sender, EventArgs e)
        {
            Computer computer = lv_billinfo.Tag as Computer;
            if (computer != null)
            {
                int idBill = BillDAO.Instance.GetUncheckBill(computer.ID);
                if (idBill != -1)
                {
                    if (MessageBox.Show("Thanh toán " + computer.Name + ", bạn chắc chắn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string strtimePrice = tb_timeprice.Text.Split(',')[0].Replace(".", string.Empty);
                        string strfoodPrice = tb_foodprice.Text.Split(',')[0].Replace(".", string.Empty);
                        int timePrice = Convert.ToInt32(strtimePrice);
                        int foodPrice = Convert.ToInt32(strfoodPrice);
                        string totalTime = lb_totaltime.Text;
                        BillDAO.Instance.CheckOut(idBill,timePrice,foodPrice,totalTime);
                        timer1.Stop();
                        Show_Bill_Infor(computer.ID);
                        LoadComputer();
                    }
                }
            }

        }

        //time

        private void timer2_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            Computer computer = lv_billinfo.Tag as Computer;
            int idBill = BillDAO.Instance.GetUncheckBill(computer.ID);
            if (idBill != -1)
            {
                int hour, minute;
                int hourPrice = 0;
                int starthour = Convert.ToInt32(lb_starthour.Text);
                int startminute = Convert.ToInt32(lb_startminute.Text);
                int finalhour = Convert.ToInt32(lb_finalhour.Text);
                int finalminute = Convert.ToInt32(lb_finalminute.Text);

                if (finalminute >= startminute)
                {
                    hour = finalhour - starthour;
                    minute = finalminute - startminute;
                }

                else
                {
                    minute = 60 - startminute + finalminute;
                    hour = finalhour - starthour - 1;
                    if (minute > 59)
                    {
                        hour++;
                        minute = 0;
                    }
                }
   
                lb_totaltime.Text = hour.ToString() + " giờ " + minute.ToString() + " phút";
                if (minute % 5 == 0)
                    hourPrice = hour * 24000 + 400 * minute;
                else
                {
                    int tmp_minute = minute - (minute % 5);
                    hourPrice = hour * 24000 + 400 * tmp_minute;
                }
                tb_timeprice.Text = hourPrice.ToString("c",culture);
                string strtimePrice = tb_timeprice.Text.Split(',')[0].Replace(".", string.Empty);
                string strfoodPrice = tb_foodprice.Text.Split(',')[0].Replace(".", string.Empty);
                int timePrice = Convert.ToInt32(strtimePrice);
                int foodPrice = Convert.ToInt32(strfoodPrice);
                int totalprice = timePrice + foodPrice;
                tb_totalprice.Text = totalprice.ToString("c", culture);
            }
            else
            {
                lb_totaltime.Text = "0 giờ 0 phút";
                tb_totalprice.Text = "0,00 ₫";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Computer computer = lv_billinfo.Tag as Computer;
            int idBill = BillDAO.Instance.GetUncheckBill(computer.ID);
            if (idBill != -1)
            {
                lb_finalhour.Text = DateTime.Now.ToString("HH");
                lb_finalminute.Text = DateTime.Now.ToString("mm");
            }
            else
            {
                lb_finalhour.Text = "00";
                lb_finalminute.Text = "00";
            }
        }

        #endregion
    }
}
