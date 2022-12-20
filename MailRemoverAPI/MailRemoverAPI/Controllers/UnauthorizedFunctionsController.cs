﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MailRemoverAPI.Interfaces;

namespace MailRemoverAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnauthorizedFunctionsController : ControllerBase
    {
        public ICo2FootprintCalcService _co2FootprintCalcService;

        public UnauthorizedFunctionsController(ICo2FootprintCalcService co2FootprintCalcService)
        {
            _co2FootprintCalcService = co2FootprintCalcService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCo2Eggs([FromQuery] int totalMessages)
        {
            var resultEggs = _co2FootprintCalcService.EggCalculator(totalMessages);
            var resultCO2 = _co2FootprintCalcService.Co2FootprintCalculatorKg(totalMessages);

            return Ok(new {eggs = resultEggs, co2 = resultCO2});
        }
    }

}