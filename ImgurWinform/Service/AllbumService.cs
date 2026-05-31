using ImgurAPI;
using ImgurAPI.Allbums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinform.Service
{
    internal class AllbumService
    {
        ImgurContext imgurcontext;

        public AllbumService()
        {
            imgurcontext = new ImgurContext();
        }
        public async Task<AllbumGetResponseModel> GetAllbum()
        {
            return await imgurcontext.Allbum.GetAllbum();
        }

        public async Task PostimagetoAllbum(string allbumID, string imageID)
        {
            await imgurcontext.Allbum.PostImageAdd(allbumID, imageID);
        }

        public async Task<AllbumCreateResponseModel.Data> PostAllbumCreate(string albumname, string privacytype)
        {
            var AllbumCreateResponse = await imgurcontext.Allbum.PostAllbumCreate(albumname, privacytype);
            return AllbumCreateResponse.data;
        }

        public async Task<AllbumShareGalleryModel> PostAllbumShareGallery(string albumID, string title)
        {
            return await imgurcontext.Allbum.SharetoGallery(albumID, title);
            
        }
        public async Task<GetAllbumImagesModel.Datum[]> GetAllbumImages(string albumID)
        {
            var GetAlbumImages = await imgurcontext.Allbum.GetAllbumImages(albumID);
           
            return GetAlbumImages.data;
        }
    }
}
