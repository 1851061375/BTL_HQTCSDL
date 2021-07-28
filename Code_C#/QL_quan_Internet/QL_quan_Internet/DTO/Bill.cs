using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_quan_Internet.DTO
{
    public class Bill
    {
        public Bill (int id, int idcomputer, DateTime? date, DateTime? timecheckin,DateTime? timecheckout, int status)
        {
            this.ID = id;
            this.IDComputer = idcomputer;
            this.Date = date;
            this.TimeCheckIn = timecheckin;
            this.TimeCheckOut = timecheckout;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDComputer = (int)row["idcomputer"];
            this.Date = (DateTime?)row["date"];
            //this.TimeCheckIn = (DateTime?)row[" timecheckin"];
            //this.TimeCheckOut = (DateTime?)row["timecheckout"];
            this.Status = (int)row["status"];
        }

        private Bill() { }

        private int iD;
        private int iDComputer;
        private DateTime? date;
        private DateTime? timeCheckIn;
        private DateTime? timeCheckOut;
        private int status;

        public int ID { get => iD; set => iD = value; }
        public int IDComputer { get => iDComputer; set => iDComputer = value; }
        public DateTime? Date { get => date; set => date = value; }
        public DateTime? TimeCheckIn { get => timeCheckIn; set => timeCheckIn = value; }
        public DateTime? TimeCheckOut { get => timeCheckOut; set => timeCheckOut = value; }
        public int Status { get => status; set => status = value; }
    }
}
