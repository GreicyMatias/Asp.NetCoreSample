using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Retornar a URL de onde encontra-se o fonte no github.
        /// </summary>
        /// <returns>URL contendo o repositório do Github com o código.</returns>
        [HttpGet("showmethecode")]
        public ActionResult<string> GetUrl()
        {
            return "https://github.com/GreicyMatias/Asp.NetCoreSample";
        }

        /// <summary>
        /// Faz um cálculo de juros compostos
        /// </summary>
        /// <param name="valorinicial">Valor inicial em decimal</param>
        /// <param name="meses">Valor inteiro, represetando tempo em meses</param>
        /// <returns>Resultado do calculo</returns>
        [HttpGet("calculajuros")]
        public ActionResult<string> Get([FromQuery(Name = "valorinicial")] double initialValue, [FromQuery(Name = "meses")] int months)
        {
            return (initialValue * Math.Pow((1 + 0.01), months)).ToString("N2");
        }
    }
}
