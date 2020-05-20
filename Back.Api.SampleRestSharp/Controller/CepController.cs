using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back.Api.SampleRestSharp.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Back.Api.SampleRestSharp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly ICepService _cepService;
        public CepController(ICepService cepService)
        {
            _cepService = cepService;
        }
        [HttpGet]
        [Route("{cep}")]
        public IActionResult GetCep(string cep)
        {
            var address = _cepService.GetAddressByCep(cep);
            return Ok(address);
        }
    }
}