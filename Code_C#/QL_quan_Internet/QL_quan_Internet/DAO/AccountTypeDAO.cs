using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_quan_Internet.DAO
{
    public class AccountTypeDAO
    {
        private static AccountTypeDAO instance;

        public static AccountTypeDAO Instance
        {
            get { if (instance == null) instance = new AccountTypeDAO(); return instance; }
            private set { AccountTypeDAO.instance = value; }
        }

        private AccountTypeDAO() {}

        public DataTable GetAccountType()
        {
            return DataProvider.Instance.ExecuteQuery("select* from AccountType");
        }
    }
}
