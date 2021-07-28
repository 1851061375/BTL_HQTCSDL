using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_quan_Internet.DTO;

namespace QL_quan_Internet.DAO
{
    public class Bill_InfoDAO
    {
        private static Bill_InfoDAO instance;

        public static Bill_InfoDAO Instance 
        {
            get { if (instance == null) instance = new Bill_InfoDAO(); return Bill_InfoDAO.instance; }
            private set { Bill_InfoDAO.instance = value; }
        }

        private Bill_InfoDAO() { }

        public List<Bill_Info> GetBillInfoByIDComputer(int id)
        {
            List<Bill_Info> menuList = new List<Bill_Info>();
            string query = @"SELECT BI.FoodName,BI.Quantity,F.Price
                           FROM dbo.Bill AS B,dbo.BillInfo AS BI,dbo.Food AS F,dbo.Computer AS C
                           WHERE B.Id = BI.idBill AND F.FoodName = BI.FoodName AND C.Id = B.idComputer AND B.Status = 0 AND C.Id =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Bill_Info menu = new Bill_Info(item);
                menuList.Add(menu);
            }
            return menuList;
        }

        public void InsertBill_Info(int idBill, string foodName, int quantity)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertBill_Info @idBill , @foodName , @quantity", new object[] { idBill, foodName, quantity });
        }

        public void DecreaseFood (int idBill, string foodName, int quantity)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_DecreaseFood @idBill , @foodName , @quantity", new object[] { idBill, foodName, quantity });
        }

        public void DeleteFood(int idBill, string foodName)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_DeleteFood @idBill , @foodName", new object[] { idBill, foodName});
        }


    }
}
