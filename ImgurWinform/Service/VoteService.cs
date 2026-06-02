using ImgurAPI.Gallerys;
using ImgurWinform.Enums;
using ImgurWinform.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinform.Service
{
    internal class VoteService
    {
        ImgurAPI.ImgurContext imgur;
       //call ImgurAPI
        public VoteService() 
        {
           imgur  = new ImgurAPI.ImgurContext();  
            
        }
        public (VoteType, int) SetVotePoint(VoteDTO model)
        {
            switch (model.PreviousStage)
            {
                case VoteType.veto:
                    model.Point = (model.CurrentStage == VoteType.up) ? (model.Point + 1) : (model.Point - 1);                    
                    model.PreviousStage = (model.CurrentStage == VoteType.up) ? VoteType.up : VoteType.down;
                    break;
                case VoteType.up:
                    model.Point = (model.CurrentStage == VoteType.down) ? (model.Point - 2) : (model.Point - 1);                  
                    model.PreviousStage = (model.CurrentStage == VoteType.down) ? VoteType.down : VoteType.veto;
                    break;
                case VoteType.down:
                    model.Point = (model.CurrentStage == VoteType.up) ? (model.Point + 2) : (model.Point + 1);                   
                    model.PreviousStage = (model.CurrentStage == VoteType.up) ? VoteType.up : VoteType.veto;
                    break;
            }
            int temp = (int)model.CurrentStage;
            ImgurAPI.EnumUtilty.Votetype type = (ImgurAPI.EnumUtilty.Votetype)temp;
            imgur.Gallery.PostGalleryVote(model.GalleryID, type);                                                                       
            return (model.PreviousStage, model.Point);
        }
        public (VoteType, int, int) SetVoteUpDown(VoteDTO VoteDTO)
        {
            switch (VoteDTO.PreviousStage)
            {
                case VoteType.veto:
                    VoteDTO.Ups = (VoteDTO.CurrentStage == VoteType.up) ? (VoteDTO.Ups + 1) : (VoteDTO.Ups);
                    VoteDTO.Downs = (VoteDTO.CurrentStage == VoteType.up) ? (VoteDTO.Downs) : (VoteDTO.Downs + 1);
                    VoteDTO.PreviousStage = (VoteDTO.CurrentStage == VoteType.up) ? VoteType.up : VoteType.down;
                    break;
                case VoteType.up:
                    VoteDTO.Ups = (VoteDTO.CurrentStage == VoteType.down) ? (VoteDTO.Ups - 2) : (VoteDTO.Ups - 1);
                    VoteDTO.Downs = (VoteDTO.CurrentStage == VoteType.down) ? (VoteDTO.Downs + 1) : (VoteDTO.Downs);
                    VoteDTO.PreviousStage = (VoteDTO.CurrentStage == VoteType.down) ? VoteType.down : VoteType.veto;
                    break;
                case VoteType.down:
                    VoteDTO.Ups = (VoteDTO.CurrentStage == VoteType.up) ? (VoteDTO.Ups + 1) : (VoteDTO.Ups);
                    VoteDTO.Downs = (VoteDTO.CurrentStage == VoteType.up) ? (VoteDTO.Downs - 2) : (VoteDTO.Downs - 1);
                    VoteDTO.PreviousStage = (VoteDTO.CurrentStage == VoteType.up) ? VoteType.up : VoteType.veto;
                    break;
            }
       
            int temp = (int)VoteDTO.CurrentStage;
            ImgurAPI.EnumUtilty.Votetype type = (ImgurAPI.EnumUtilty.Votetype)temp;
            imgur.Gallery.PostGalleryVote(VoteDTO.GalleryID, type);
            return (VoteDTO.PreviousStage, VoteDTO.Ups, VoteDTO.Downs);
        }
        public (Color,Color) GetVoteColor(VoteType stage)
        {
            switch (stage)
            {
                case VoteType.up:
                    return (Color.Green, Color.Black);
                case VoteType.down:
                    return (Color.Black, Color.Red);
                case VoteType.veto:
                    return (Color.Black, Color.Black);
                default:
                    return(Color.Black, Color.Black);
            }
        }
    }
}
