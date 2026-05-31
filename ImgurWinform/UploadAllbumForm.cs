using ImgurWinform.Models;
using ImgurWinform.Service;
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
    public partial class UploadAllbumForm : Form
    {
        AllbumService allbumService = new AllbumService();
        List<KeyValueModel> allbumdata = new List<KeyValueModel>();
        public UploadAllbumForm()
        {
            InitializeComponent();
            GetAllumdata();
        }

        private async void GetAllumdata()
        {
            var allbumresponse = await allbumService.GetAllbum();
            comboBox1.DataSource = null;

            allbumdata.Add(new KeyValueModel("Please choose allbum", ""));
            foreach (var item in allbumresponse.data)
            {
                allbumdata.Add(new KeyValueModel(item.title, item.id));
            }
            comboBox1.DataSource = allbumdata;
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }
      

        private async void SelectAlbum(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue is string)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                var imagelink = await allbumService.GetAllbumImages(comboBox1.SelectedValue.ToString());
                foreach (var image in imagelink)
                {
                    pictureBox.LoadAsync(image.link);
                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
            }
            
        }
    }
}
