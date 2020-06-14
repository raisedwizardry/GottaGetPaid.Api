using GottaGetPaid.Api.Models;
using GottaGetPaid.Data.Models;
using GottaGetPaid.Data.Models.Enums;
using GottaGetPaid.Data.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GottaGetPaid.Data.Services
{
    public class PaydayService : IPaydayService
    {

        public async Task<Payday> DetermineNextPayDateWeekly(DateTime startDate, PayType frequency)
        {
            DateTime calculatedDate = DetermineWeeklyNextDate(startDate, frequency);
            var singlePayday = new Payday {
                PayDate = calculatedDate,
                DayOfWeek = calculatedDate.DayOfWeek,
                Regularity = frequency
            };
            return singlePayday;
        }
        public async Task<List<Payday>> DeterminePayDatesWeekly(DateTime startDate, PayType frequency, TimeSpan length)
        {
            return new List<Payday>() { };
        }
        public async Task<Payday> DetermineNextPayDatesMonthly(DateTime startDate, PayType frequency)
        {
            DateTime calculatedDate = DetermineMonthlyNextDate(startDate, frequency);
            return new Payday
            {
                PayDate = calculatedDate,
                DayOfWeek = calculatedDate.DayOfWeek,
                Regularity = frequency
            };
        }
        public async Task<List<Payday>> DeterminePayDatesMonthly(DateTime startDate, PayType frequency, TimeSpan length)
        {
            return new List<Payday>() { };
        }

        public static DateTime DetermineWeeklyNextDate(DateTime date, PayType frequency)
        {
            while (date <= DateTime.Now)
            {
                date = date.AddDays((double)frequency);
            }
            return date;
        }

        public static DateTime DetermineMonthlyNextDate(DateTime date, PayType frequency)
        {
            while (date <= DateTime.Now)
            {
                date = date.AddMonths((int)frequency);
            }
            return date;
        }
    }
}
