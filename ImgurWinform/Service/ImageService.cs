using ImgurAPI;
using ImgurAPI.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinform.Service
{
    internal class ImageService
    {
        ImgurContext imgurContext;

        public ImageService()
        {
            imgurContext = new ImgurContext();
        }

        public async Task<ImageLoadResponseModel> Loadimage(string path, string filename)
        {
            var ImageResponse = await imgurContext.Image.PostImage(path, filename);
            return ImageResponse;
        }
        public async Task<ImageLoadResponseModel> Loadimage(string path, string title = null, string descripition = null)
        {
            var ImageResponse = await imgurContext.Image.PostImage(path, title, descripition);
            return ImageResponse;
        }
    }
}
