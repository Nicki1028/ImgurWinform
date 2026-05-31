using ImgurAPI;
using ImgurAPI.Gallerys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinform
{
    public partial class Gallery : Form
    {
        private List<GalleryResponseModel.Datum> allData = new List<GalleryResponseModel.Datum>();
        private const int itemsPerPage = 6;
        public Gallery()
        {
            InitializeComponent();
            pagination1.PageChanged += OnPageChanged;
        }

        private void OnPageChanged(int pageIndex)
        {
            RenderPage(pageIndex);
        }

        private void RenderPage(int pageIndex)
        {
            var pageData = allData
                .Skip(pageIndex * itemsPerPage)
                .Take(itemsPerPage);

            flowLayoutPanel1.Controls.Clear();
            foreach (var data in pageData)
            {
                GalleryItem item = new GalleryItem(data);
                item.ItemClicked += (sender, e) =>
                {
                    GalleryDetailForm detailForm = new GalleryDetailForm(data);
                    detailForm.Show();
                };
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ImgurContext context = new ImgurContext();
            GalleryResponseModel responseModel = await context.Gallery.GetGallery(Search.Text, Sort.Text);
            
            allData = responseModel.data.ToList();
            
            // 同步總筆數給 Pagination，讓它計算總頁數
            pagination1.Total = allData.Count;

            RenderPage(0);          
        }
    }
}
