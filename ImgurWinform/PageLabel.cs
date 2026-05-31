using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinform
{
    internal class PageLabel:Label
    {
        public PageLabel(string name) 
        {
            Text = name;
            Font = new Font("微軟正黑體", 15, FontStyle.Bold);
            Width = 50;
        }

        public void Reset()
        {
            ForeColor = Color.Black;
        }

        public void Active()
        {
           ForeColor = Color.Blue;
        }
    }
}
