using ImgurAPI.Commends;
using ImgurAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ImgurAPI.Commends.CommendResponseModel;

namespace ImgurWinform.Service
{
    internal class CommendService
    {
        ImgurContext imgurContext;

        public CommendService()
        {
           imgurContext =  new ImgurContext();
        }

        public async Task<List<Datum>> Comments(string ID)
        {           
            var commendResponse = await imgurContext.Commend.GetGalleryCommend(ID, EnumUtilty.Commendtype.top);
            return commendResponse.data;
        }
        public async Task<Datum> GetSingleCommend(string commentID)
        {
            var SinglecommendResponse = await imgurContext.Commend.GetGalleryCommend(commentID);
            return SinglecommendResponse.data;
        }
        public async Task<CommendCreateResponseModel.Data> PostCommend(string imageID, string text)
        {
            var postcommentResponse = await imgurContext.Commend.PostCommend(imageID, text);
            return postcommentResponse.data;
        }

        public async Task<CommendCreateResponseModel.Data> PostReply(string commendID, string imageID, string text)
        {
            var postcommentResponse = await imgurContext.Commend.PostReply(commendID, imageID, text);
            return postcommentResponse.data;
        }
    }
}
