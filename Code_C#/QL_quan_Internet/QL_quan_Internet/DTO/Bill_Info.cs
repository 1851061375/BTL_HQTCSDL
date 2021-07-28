using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_quan_Internet.DTO
{
    public class Bill_Info
    {
        private string foodName;
        private int quantity;
        private int price;
        public Bill_Info(string foodname, int quantity, int price)
        {
            this.FoodName = foodname;
            this.Quantity = quantity;
            this.Price = price;
        }

        public Bill_Info(DataRow row)
        {
            this.FoodName = row["foodname"].ToString();
            this.Quantity =(int)row["quantity"];
            this.Price = (int)row["price"];
        }

        public int Quantity { get => quantity; set => quantity = value; }
       // public int Price { get => price; set => price = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int Price { get => price; set => price = value; }
    }
}
