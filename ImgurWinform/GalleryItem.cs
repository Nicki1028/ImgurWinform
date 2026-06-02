using ImgurAPI.Gallerys;
using ImgurWinform.Enums;
using ImgurWinform.Models;
using ImgurWinform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinform
{
    public partial class GalleryItem : UserControl
    {
        VoteService voteService = new VoteService();
        VoteDTO voteModel;
        GalleryResponseModel.Datum _datum;
        public event EventHandler ItemClicked;
        public GalleryItem(GalleryResponseModel.Datum data)
        {            
            InitializeComponent();
            _datum = data;
            pictureBox1.LoadAsync($"https://i.imgur.com/{data.cover}.jpeg");
            Title.Text = data.title;
            Ups.Text = data.ups.ToString();
            Downs.Text = data.downs.ToString();
            CommentCount.Text = data.comment_count.ToString();
            Views.Text = data.views.ToString();
            
            // 讓點擊任何子控制項都能觸發 ItemClicked
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl == Up || ctrl == Down || ctrl == label4 || ctrl == label5)
                    continue;
                ctrl.Click += (s, e) => ItemClicked?.Invoke(this, e);
            }
            this.Click += (s, e) => ItemClicked?.Invoke(this, e);
        }
          
        private async void Comment_ClickAsync(object sender, EventArgs e)
        {
            CommendService commendService = new CommendService();

            Form commentForm = new Form
            {
                Text = _datum.title,
                Size = new Size(400, 600),
                StartPosition = FormStartPosition.CenterParent,
                AutoScroll = true
            };

            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true
            };
            commentForm.Controls.Add(panel);
            commentForm.Show();

            try
            {
                var comments = await commendService.Comments(_datum.id);
                foreach (var datum in comments)
                {
                    var item = new CommentItem(datum);
                    item.Width = panel.Width - 25;
                    panel.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入留言失敗：{ex.Message}");
            }
        }

        private void vote_Click(object sender, EventArgs e)
        {
            Label vote = (Label)sender;
            Enum.TryParse(this._datum.vote?.ToString(), out VoteType PreviousStage);
            Enum.TryParse(vote.Tag.ToString(), out VoteType NowStage);
            VoteDTO VoteDTO = new VoteDTO(PreviousStage, NowStage, _datum.ups, _datum.downs, _datum.id);

            var data = voteService.SetVoteUpDown(VoteDTO);
            Ups.Text = data.Item2.ToString();
            Downs.Text = data.Item3.ToString();
           
            var getvotecolor = voteService.GetVoteColor(data.Item1);
            Up.ForeColor = getvotecolor.Item1;
            Down.ForeColor = getvotecolor.Item2;
            
        }
    }
    
}
