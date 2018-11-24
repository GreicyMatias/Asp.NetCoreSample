using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("showmethecode")]
        public ActionResult<string> Get()
        {
            return "https://github.com/GreicyMatias/Asp.NetCoreSample";
        }

        [HttpGet("calculajuros")]
        public ActionResult<string> Get([FromQuery(Name = "valorinicial")] int initialValue, [FromQuery(Name = "meses")] int months)
        {
            return (initialValue * Math.Pow((1 + 0.01), months)).ToString("N2");
        }
    }
}
