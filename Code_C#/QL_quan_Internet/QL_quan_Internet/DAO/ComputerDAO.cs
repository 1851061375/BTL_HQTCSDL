using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_quan_Internet.DTO;
using System.Data;

namespace QL_quan_Internet.DAO
{
    public class ComputerDAO
    {
        public static int height_btn = 80;
        public static int width_btn = 80;
        private static ComputerDAO instance;
        public static ComputerDAO Instance
        {
            get { if (instance == null) instance = new ComputerDAO(); return  ComputerDAO.instance; }
            private set { ComputerDAO.instance = value; }
        }
        private ComputerDAO() { }

        public List<Computer> LoadComputerList()
        {
            List<Computer> computerList = new List<Computer>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT* FROM UV_GetAllComputer");

            foreach(DataRow item in data.Rows)
            {
                Computer computer = new Computer(item);
                computerList.Add(computer);
            }

            return computerList;
        }
    }
}
