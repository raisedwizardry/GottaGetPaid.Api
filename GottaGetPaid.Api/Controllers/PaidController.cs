using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GottaGetPaid.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GottaGetPaid.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaidController : ControllerBase
    {
        private readonly IPaydayService _paydayService;
        PaidController(IPaydayService _paydayService)
        {
            _paydayService = paydayService
            var lastPaid = new Calculate.Bimonthly(date);
        }
        // GET api/calculate/givendate/monthlypaydate/{date}
        [HttpGet]
        [Route("/{Rate}/{date}")]
        public ActionResult BimonthlyDate(string date)
        {
            var results = new List<Payday>();
            
            return Ok(new { results = _paydayService.NextPayDate() });
        }
    }
}
