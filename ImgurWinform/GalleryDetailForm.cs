using ImgurAPI;
using ImgurAPI.Commends;
using ImgurAPI.Gallerys;
using ImgurWinform.Enums;
using ImgurWinform.Models;
using ImgurWinform.Service;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinform
{
    public partial class GalleryDetailForm : Form
    {
        GalleryResponseModel.Datum data;
        CommendCreateResponseModel.Data postresponse;
        VoteService voteService = new VoteService();
        CommendService commendService = new CommendService();
        ImageService imageService = new ImageService();
        public GalleryDetailForm(GalleryResponseModel.Datum data)
        {
            InitializeComponent();

            Title.Text = data.title;
            Point.Text = data.ups.ToString();        
            Like.ForeColor = data.favorite == true? Color.Red : Color.Black;
            CommendCount.Text = data.comment_count.ToString(); 
            this.data = data;
            CommentID.Text = this.data.id;
            if (this.data.vote?.ToString() == "up")
            {
                Ups.ForeColor = Color.Green;
            }
            if (this.data.vote?.ToString() == "down")
            {
                Downs.ForeColor = Color.Red;
            }
            foreach (var item in this.data.images)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = flowLayoutPanel1.Width; 
                pictureBox.Height = flowLayoutPanel1.Height;
                pictureBox.LoadAsync($"{item.link}");
                flowLayoutPanel1.Controls.Add(pictureBox);
                
            }
            GetComment(this.data.id);
        }    
        
        private async void GetComment(string ID)
        {
            var data = await commendService.Comments(ID);
            
            foreach (var item in data)
            {
                CommentItem commentItem = new CommentItem(item);
                commentItem.Click += CommentItem_Click;
                flowLayoutPanel2.Controls.Add(commentItem);
            }
        }
        private void CommentItem_Click(object sender, EventArgs e)
        {
            CommentID.Text = ((CommentItem)sender).Tag.ToString();
            CommentID.Tag = (CommentItem)sender;
        }
        private void VoteClick(object sender, EventArgs e)
        {
            Label vote = (Label)sender;           
            Enum.TryParse(this.data.vote?.ToString(), out VoteType PreviousStage);
            Enum.TryParse(vote.Tag.ToString(), out VoteType NowStage);
            VoteDTO VoteDTO = new VoteDTO(PreviousStage, NowStage, data.ups, data.id);

            var setvotepoint = voteService.SetVotePoint(VoteDTO);
            var getvotecolor = voteService.GetVoteColor(setvotepoint.Item1);
            this.data.vote = setvotepoint.Item1;
            this.data.ups = setvotepoint.Item2;
            Point.Text = setvotepoint.Item2.ToString();
            Ups.ForeColor = getvotecolor.Item1;
            Downs.ForeColor = getvotecolor.Item2;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            
            if (CommentID.Text == this.data.id)
            {
                postresponse = await commendService.PostCommend(this.data.id, text);
                Console.WriteLine(postresponse);

                var responsedata = await commendService.GetSingleCommend(postresponse.id.ToString());
                CommentItem commentItem = new CommentItem(responsedata);
                flowLayoutPanel2.Controls.Add(commentItem);
            }
            else
            {                
                var postreply = await commendService.PostReply(CommentID.Text, this.data.id, text);
                Console.WriteLine(postreply);
                var replyresponse = await commendService.GetSingleCommend(postreply.id.ToString());
                CommentItem commentitem = (CommentItem)CommentID.Tag;
                commentitem.AddReply(replyresponse, CommentItem_Click);
            }
           
        }
        private void GetID(object sender, EventArgs e)
        {
            CommentID.Text = this.data.id;
        }

        private async void 圖檔上傳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var imageresponse = await imageService.Loadimage(openFileDialog.FileName);
                textBox1.Text += "\r\n"+imageresponse.data.link;
            }
            
        }
    }
}
