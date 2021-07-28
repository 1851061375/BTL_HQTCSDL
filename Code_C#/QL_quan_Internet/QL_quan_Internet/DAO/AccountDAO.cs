using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_quan_Internet.DTO;

namespace QL_quan_Internet.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO();return instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }

        public Account GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT *FROM Account WHERE UserName =" +"'"+ username+"'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool Login(string username, string password)
        {
            //Injection
            string query = "SELECT UserName,Password FROM dbo.Account WHERE UserName = @username AND Password = @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            if (result.Rows.Count > 0)
                return true;
            return false;
        }

        public DataTable LoadListAccount()
        {
            string query = @"SELECT UserName AS [Tên người dùng],DisplayName AS [Tên hiển thị],AT.Name AS [Loại tài khoản] 
                            FROM dbo.Account AS A,dbo.AccountType AS AT
                            WHERE A.Type = AT.Type";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void UpdateAccount(string username, string displayname, int type,string oldusername)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.Account SET UserName = '"+username+"'"+",DisplayName = '"+displayname +"'" +",Type = "+type + "WHERE UserName = '"+ oldusername +"'") ;
        }

        public void InsertAccount(string username, string displayname, int type)
        {
            DataProvider.Instance.ExecuteNonQuery("INSERT dbo.Account(UserName,DisplayName,Type) VALUES ('"+username+"'"+",N'"+displayname+"'"+","+type+")");
        }

        public bool DeleteAccount(string username)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Account WHERE Type = 0 AND UserName = '" + username + "'");
            return result > 0;
        }
    }
}
