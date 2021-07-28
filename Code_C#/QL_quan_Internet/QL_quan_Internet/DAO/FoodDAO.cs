using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_quan_Internet.DTO;

namespace QL_quan_Internet.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;


        public static FoodDAO Instance 
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }

        public List<Food> GetAllFood()
        {
            List<Food> list = new List<Food>();
            string query = "SELECT* FROM dbo.UV_GetAllFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public List<Food> GetFoodByCategory(string categoryname)
        {
            List<Food> list = new List<Food>();
            string query = "EXEC GetFoodByCategory @categoryname";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { categoryname });
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public void AddFood(string name, int quantity)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Food SET CurrentQuantity = CurrentQuantity + " +"'"+ quantity +"'"+"Where FoodName =" +"N'" + name +"'");
        }
        public void DecreaseFood(string name, int quantity)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Food SET CurrentQuantity = CurrentQuantity - " + "'" + quantity + "'" + "Where FoodName =" + "N'" + name + "'");
        }
    }
}
