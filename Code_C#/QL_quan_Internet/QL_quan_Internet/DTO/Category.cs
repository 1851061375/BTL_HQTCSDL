using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_quan_Internet.DTO
{
    public class Category
    {
        private string categoryName;
        public Category (string categoryname)
        {
            this.CategoryName = categoryname;
        }

        public Category (DataRow row)
        {
            this.CategoryName = row["categoryname"].ToString();
        }
        public string CategoryName { get => categoryName; set => categoryName = value; }
    }
}
