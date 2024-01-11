using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Workshop_Eduan_240111__Fundamentals_of_Programming_.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        private readonly IFactorialService _factorialService;
        public FactorialController(IFactorialService factorialService) 
        {
            _factorialService = factorialService;
        }
        [HttpGet]
        public string GetFactorial(int number)
        {
            return _factorialService.GetFactorial(number);
        }
    }
}
