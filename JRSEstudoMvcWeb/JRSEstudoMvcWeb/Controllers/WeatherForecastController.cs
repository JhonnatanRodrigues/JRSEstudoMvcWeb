using JRSEstudoMvcWeb_Aplicacao.Calculadora;
using JRSEstudoMvcWeb_Aplicacao.Calculadora.Iterfaces;
using Microsoft.AspNetCore.Mvc;

namespace JRSEstudoMvcWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IAplicCalculadora _aplicCalculadora;

        public WeatherForecastController(IAplicCalculadora aplicCalculadora)
        {
            _aplicCalculadora = aplicCalculadora;
        }

        [Route("Calculadora")]
        [HttpPost]
        public decimal Calculadora(decimal primeiroNumero, operacoes operacao, decimal segundoNumero)
        {
            return _aplicCalculadora.Calculador(primeiroNumero, operacao, segundoNumero);
        }
    }
}