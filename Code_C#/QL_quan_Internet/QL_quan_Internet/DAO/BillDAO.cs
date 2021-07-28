using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_quan_Internet.DTO;

namespace QL_quan_Internet.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUncheckBill(int id)
        {
            string query = " SELECT*FROM dbo.Bill WHERE idComputer = " + id + " AND Status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertBill @idComputer", new object[] { id });
        }

        public void CheckOut(int id, int timePrice, int foodPrice, string totalTime)
        {
            string query = "UPDATE dbo.Bill SET Status = 1, TimeCheckOut = cast(getdate() as time),TimePrice ="+timePrice+",TotalFoodPrice ="+ foodPrice +",TotalTime = "+"N'"+totalTime+"'" +"WHERE Id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public string GetStartHour(int idComputer)
        {
            string hour;
            //null
            hour =Convert.ToString( DataProvider.Instance.ExecuteScalar("SELECT DATEPART(HOUR,TimeCheckIn) FROM dbo.Bill WHERE Status = 0  AND idComputer =" + idComputer));
            if (hour == "")
                return "00";
            if (Convert.ToInt32(hour) < 10)
                return "0" + hour;
            
            return hour;
        }

        public string GetStartMinute(int idComputer)
        {
            string minute;
            //null
            minute = Convert.ToString(DataProvider.Instance.ExecuteScalar("SELECT DATEPART(MINUTE,TimeCheckIn) FROM dbo.Bill WHERE Status = 0  AND idComputer =" + idComputer));
            if (minute == "")
                return "00";
            if (Convert.ToInt32(minute) < 10)
                return "0" + minute;

            return minute;
        }

        public DataTable GetListBillByDate(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate @date", new object[] { date });
        }

        public int GetTotalRevenueByDate(DateTime date)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate @date", new object[] { date });
            if (data.Rows.Count > 0)       
                return (int)DataProvider.Instance.ExecuteScalar("SELECT dbo.UF_RevenueByDate('" + date + "')");
            return 0;
        }
    }
}
