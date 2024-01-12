using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Services.Interfaces;

namespace Services.Services
{
    public class ImageService:IImageGenerateService
    {
        private readonly IImageAdapter _imageAdapter;
        public ImageService(IImageAdapter imageAdapter)
        {
            _imageAdapter = imageAdapter;
        }
        public string GenerateDog()
        {
            return _imageAdapter.GenerateDog();
        }
    }
}
