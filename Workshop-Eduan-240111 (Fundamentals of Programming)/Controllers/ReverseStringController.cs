using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Workshop_Eduan_240111__Fundamentals_of_Programming_.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        private readonly IReverseStringService _reverseStringService;
        public ReverseStringController(IReverseStringService reverseStringService) 
        {
            _reverseStringService = reverseStringService;
        }
        [HttpGet]
        public string GetReverseString(string unreversed)
        {
            return _reverseStringService.ReverseString(unreversed);
        }
    }
}
