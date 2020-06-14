using GottaGetPaid.Data.Models;
using GottaGetPaid.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaGetPaid.Api.Models
{
    public class Payday
    {
        public DateTime PayDate { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public PayType Regularity { get; set; }
    }
}
