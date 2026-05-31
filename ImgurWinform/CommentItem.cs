using ImgurAPI.Commends;
using ImgurWinform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using URLtest;
using ImgurWinform.Models;
using ImgurWinform.Enums;
using static System.Net.WebRequestMethods;

namespace ImgurWinform
{
    //regular expression get url put dynamic picture box
    public partial class CommentItem : UserControl
    {
        CommendResponseModel.Datum data;
        VoteService voteService = new VoteService();
        public CommentItem(CommendResponseModel.Datum data)
        {
            InitializeComponent();
          
            this.data = data;
            Tag = data.id;
            Point.Text = data.points.ToString();
            ID.Text = data.author;
            Height = 140;
            button1.Visible = false;
            
            foreach (TextURL textURL in CheckURL(data.comment))
            {
                if (this.data.vote?.ToString() == "up")
                {
                    up.ForeColor = Color.Green;
                }
                if (this.data.vote?.ToString() == "down")
                {
                    down.ForeColor = Color.Red;
                }

                if (!string.IsNullOrEmpty(textURL.text))
                {
                    Label label = new Label() { Text = textURL.text };
                    label.Width = 280;
                    label.Font = new Font("Times New Roman", 14);
                    flowLayoutPanel2.Controls.Add(label);
                }

                if (!string.IsNullOrEmpty(textURL.url))
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 70;
                    pictureBox.Height = 60;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.LoadAsync(textURL.url);
                    flowLayoutPanel2.Controls.Add(pictureBox);
                }
            }

            if (data.children.Count > 0)
            {
                button1.Visible = true;
            }
            for (int i = 0; i < data.children.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(new CommentItem(data.children[i]));
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
           ChangePanelHeight();
        }

        private void ChangePanelHeight()
        {
            if (data.children.Count > 0)
            {
                button1.Visible = true;
            }

            if (Height == 140)
            {
                if (data.children.Count > 3)
                {
                    Height = 520;
                }
                else
                {
                    Height = (data.children.Count + 1) * 140;
                }
            }
            else
            {
                Height = 140;
            }
        }

        private List<TextURL> CheckURL(string url)
        {
            string pattern = @"(https?://\S+\.(jpg|png|gif|jpeg))";
            Regex regex = new Regex(pattern);

            List<TextURL> URLdata = new List<TextURL>();
            int lastEnd = 0;
            foreach (Match match in regex.Matches(url))
            {
                int start = match.Index;
                int end = start + match.Length;

                // 取得動態文字部分
                string dynamicText = url.Substring(lastEnd, start - lastEnd).Trim();
                TextURL textURL = new TextURL(dynamicText, match.Value);
                URLdata.Add(textURL);
                lastEnd = end;
            }
            // 檢查是否還有剩餘的動態文字部分
            string remainingText = url.Substring(lastEnd).Trim();
            TextURL textURL1 = new TextURL(remainingText, "");
            if (!string.IsNullOrEmpty(remainingText))
            {
                URLdata.Add(textURL1);
            }
            return URLdata;
            //// 輸出結果

        }

        private void Voteclicks(object sender, EventArgs e)
        {
            Label vote = (Label)sender;
            Console.WriteLine(vote.Tag);
            Enum.TryParse(this.data.vote?.ToString(), out VoteType PreviousStage);
            Enum.TryParse(vote.Tag.ToString(), out VoteType NowStage);
            VoteDTO VoteDTO = new VoteDTO(PreviousStage, NowStage, data.points, data.image_id);

            var setvotepoint = voteService.SetVotePoint(VoteDTO);
            var getvotecolor = voteService.GetVoteColor(setvotepoint.Item1);
            this.data.vote = setvotepoint.Item1.ToString();
            this.data.points = setvotepoint.Item2;
            Point.Text = setvotepoint.Item2.ToString();
            up.ForeColor = getvotecolor.Item1;
            down.ForeColor = getvotecolor.Item2;
        }


        public void AddReply(CommendResponseModel.Datum replyresponse, EventHandler eventHandler)
        {
            CommentItem commentItem = new CommentItem(replyresponse);
            
            commentItem.Click += eventHandler;
            data.children.Add(replyresponse);
            flowLayoutPanel1.Controls.Add(commentItem);
            ChangePanelHeight();
        }

    }
}