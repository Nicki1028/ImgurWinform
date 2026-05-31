using ImgurAPI.Allbums;
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
    public partial class UploadImageForm : Form
    {
        ImageService imageService = new ImageService();
        AllbumService allbumService = new AllbumService();
        List<KeyValueModel> allbumdata = new List<KeyValueModel>();
        AllbumCreateResponseModel.Data allbumcreateresponse;
        public UploadImageForm()
        {
            InitializeComponent();
            GetAllumdata();          
        }

        private async void  GetAllumdata()
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

        private async void button1_Click(object sender, EventArgs e)
        {        
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.LoadAsync(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                var imageloadresponse = await imageService.Loadimage(ofd.FileName, Title.Text, Descirpition.Text);
                if (checkBox1.Checked)
                {
                    await Addallbum();                  
                    await allbumService.PostimagetoAllbum(allbumcreateresponse.id, imageloadresponse.data.id);
                    if (checkBox2.Checked)
                    {                        
                        await allbumService.PostAllbumShareGallery(allbumcreateresponse.id, textBox1.Text);
                        return;
                    }
                }                                          
                else
                {                   
                    await allbumService.PostimagetoAllbum(comboBox1.SelectedValue.ToString(), imageloadresponse.data.id);
                }
            }                             
        }
       
        private async Task<AllbumCreateResponseModel.Data> Addallbum()
        {                                  
            allbumcreateresponse = await allbumService.PostAllbumCreate(textBox1.Text, "hidden");
            allbumdata.Add(new KeyValueModel(textBox1.Text, allbumcreateresponse.id));
            
            return allbumcreateresponse;
        }  
    }
}