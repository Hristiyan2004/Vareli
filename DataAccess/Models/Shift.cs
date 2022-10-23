using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Shift
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
