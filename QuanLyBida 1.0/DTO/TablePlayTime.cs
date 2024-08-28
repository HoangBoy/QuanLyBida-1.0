using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBida_1._0.DTO
{
    internal class TablePlayTime
    {
        public int TableID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TablePlayTime(int tableID, DateTime startTime, DateTime endTime)
        {
            TableID = tableID;
            StartTime = startTime;
            EndTime = endTime;
        }

        public TablePlayTime()
        {

        }
    }
}
