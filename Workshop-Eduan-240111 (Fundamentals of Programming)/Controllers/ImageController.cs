using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Workshop_Eduan_240111__Fundamentals_of_Programming_.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageGenerateService _imageGenerateService;
        public ImageController(IImageGenerateService imageservice,IImageAdapter adapter) 
        {
            _imageGenerateService = imageservice;
        }
        [HttpGet]
        public string GenerateDogImage()
        {
            return _imageGenerateService.GenerateDog();
        }
    }
}
