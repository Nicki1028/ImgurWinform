using ImgurAPI.Gallerys;
using ImgurWinform.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinform.Models
{
    internal class VoteDTO
    {
        public VoteType PreviousStage { get; set; }
        public VoteType CurrentStage { get; set; }
        public int Point { get; set; }
        public string GalleryID { get; set; }
        public int Ups {  get; set; }
        public int Downs { get; set; }
        public VoteDTO(VoteType PreviousStage,VoteType CurrentStage,int Point, string GalleryID)
        {
            this.PreviousStage = PreviousStage;
            this.CurrentStage = CurrentStage;
            this.Point = Point;
            this.GalleryID = GalleryID;
        }
        public VoteDTO(VoteType PreviousStage, VoteType CurrentStage, int Ups, int Downs, string GalleryID)
        {
            this.PreviousStage = PreviousStage;
            this.CurrentStage = CurrentStage;
            this.Ups = Ups;
            this.Downs = Downs;
            this.GalleryID = GalleryID;
            
        }

    }
}
