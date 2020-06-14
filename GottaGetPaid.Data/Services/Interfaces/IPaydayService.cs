using GottaGetPaid.Api.Models;
using GottaGetPaid.Data.Models;
using GottaGetPaid.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GottaGetPaid.Data.Services.Interfaces
{
    public interface IPaydayService
    {
        public Task<Payday> DetermineNextPayDateWeekly(DateTime startDate, PayType frequency);
        public Task<List<Payday>> DeterminePayDatesWeekly(DateTime startDate, PayType frequency, TimeSpan length); 
        public Task<Payday> DetermineNextPayDatesMonthly(DateTime startDate, PayType frequency);
        public Task<List<Payday>> DeterminePayDatesMonthly(DateTime startDate, PayType frequency, TimeSpan length);
    }
}
