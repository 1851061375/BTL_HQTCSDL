using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_quan_Internet.DTO
{
    public class Food
    {
        private string foodName;
        private string categoryName;
        private int price;
        private string unit;
        private int currentQuantity;

        public Food(string foodname, string categoryname, int price, string unit,int currentquantity)
        {
            this.FoodName = foodname;
            this.CategoryName = categoryname;
            this.Price = price;
            this.Unit = unit;
            this.CurrentQuantity = currentquantity;
        }

        public Food (DataRow row )
        {
            this.FoodName = row["foodname"].ToString();
            this.CategoryName = row["categoryname"].ToString();
            this.Price = (int)row["price"];
            this.Unit = row["unit"].ToString();
            this.CurrentQuantity = (int)row["currentquantity"];
        }
        public int Price { get => price; set => price = value; }
        public string Unit { get => unit; set => unit = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public int CurrentQuantity { get => currentQuantity; set => currentQuantity = value; }
    }
}
