using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaGetPaid.Api.Models
{
    public class Payday
    {
        public DateTime PayDate { get; set; }
        public string DayOfWeek { get; set; }
        public string Regularity { get; set; }
    }
}
