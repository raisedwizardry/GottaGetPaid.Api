using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GottaGetPaid.Api.Models;
using GottaGetPaid.Data.Models.Enums;
using GottaGetPaid.Data.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GottaGetPaid.Api.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    [ApiController]
    public class PaidController : ControllerBase
    {
        private readonly IPaydayService _paydayService;
        PaidController(IPaydayService paydayService)
        {
            _paydayService = paydayService;
        }
        // GET api/calculate/givendate/monthlypaydate/{date}
        [HttpGet("paid/{frequency}/{startDate}")]
        [ProducesResponseType(typeof(Payday), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(void), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetNextPaidDatesByStartDate(DateTime startDate, string frequency)
        {
            var payFrequency = PayType.Weekly;
            var results = await _paydayService.DetermineNextPayDateWeekly(startDate, payFrequency);
            return Ok(results);
        }
    }
}
