using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_quan_Internet.DTO
{
    public class Account
    {
        public Account(string username, string displayname, int type, string password = null)
        {
            this.UserName = username;
            this.DisplayName = displayname;
            this.Type = type;
            this.Password = password;
        }

        public Account (DataRow row)
        {
            this.UserName = row["username"].ToString();
            this.DisplayName = row["displayname"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }

        private string userName;
        private string displayName;
        private string password;
        private int type;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
