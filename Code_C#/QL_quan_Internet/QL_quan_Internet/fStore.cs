using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_quan_Internet.DAO;
using QL_quan_Internet.DTO;

namespace QL_quan_Internet
{
    public partial class fStorage : Form
    {
        public fStorage()
        {
            InitializeComponent();
            LoadFood();
        }
        #region methods
        void LoadFood()
        {
            lv_store.Items.Clear();
            List<Food> listFood = FoodDAO.Instance.GetAllFood();
            foreach (Food item in listFood)
            {
                ListViewItem lv_item = new ListViewItem(item.FoodName.ToString());
                lv_item.SubItems.Add(item.Unit.ToString());
                lv_item.SubItems.Add(item.Price.ToString());
                lv_item.SubItems.Add(item.CurrentQuantity.ToString());
                lv_store.Items.Add(lv_item);
            }
        }
        #endregion

        #region event
        string foodName;
        private void lv_store_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                ListViewItem item = lv.SelectedItems[0];
                foodName = item.Text;
            }
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            if (foodName != null)
            {
                FoodDAO.Instance.AddFood(foodName, (int)num_quantity.Value);
                LoadFood();
            }
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            if (foodName != null)
            {
                FoodDAO.Instance.DecreaseFood(foodName, (int)num_quantity.Value);
                LoadFood();
            }
        }

        #endregion


    }
}
