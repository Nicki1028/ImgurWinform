using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ImgurWinform
{
    public partial class Pagination : UserControl
    {
        int _total = 274;
        public int Total 
        {
            set 
            { 
                _total = value;
                InitPageService();
            } 
        }
        int perPageCount = 10;
        int PaginationCount = 5;

        PaginationService paginationService;
        private PageLabel pagenow = null;

        public event Action<int> PageChanged;

        public Pagination()
        {
            InitializeComponent();         
            InitPageService();
        }

        private void InitPageService()
        {
            paginationService = new PaginationService(_total, perPageCount, PaginationCount);
            DirectionGenerate();
            paginationService.ChangePage(Direction.Next);
            var pages = paginationService.Pagegenerate(Direction.Next);
            PageGenerate(pages);
            PageNow(1);
        }

        public void DirectionGenerate()
        {           
            PageLabel Doublelast = new PageLabel("<<");
            Doublelast.Tag = 3;
            Doublelast.Click += Page_Direction_Click;
            flowLayoutPanel2.Controls.Add(Doublelast);

            PageLabel last = new PageLabel("<");
            last.Tag = 1;
            last.Click += Page_Direction_Click;
            flowLayoutPanel2.Controls.Add(last);

            PageLabel nextmark = new PageLabel(">");
            nextmark.Tag = 0;
            nextmark.Click += Page_Direction_Click;
            flowLayoutPanel4.Controls.Add(nextmark);

            PageLabel Doublenextmark = new PageLabel(">>");
            Doublenextmark.Tag = 2;
            Doublenextmark.Click += Page_Direction_Click;
            flowLayoutPanel4.Controls.Add(Doublenextmark);
        }
        public void PageGenerate(List<int> indexList)
        {
            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < indexList.Count; i++)
            {
                PageLabel pageNumber = new PageLabel(indexList[i].ToString());
                pageNumber.Click += PageNumber_Click;
                flowLayoutPanel1.Controls.Add(pageNumber);
            }

        }

        private void PageNow(int pageIndex)
        {
            if (pagenow != null)
                pagenow.Reset();

            if (pageIndex > PaginationCount)
            {
                pageIndex = pageIndex % PaginationCount == 0 ? (pageIndex % PaginationCount) + PaginationCount : pageIndex % PaginationCount;
            }
            pagenow = (PageLabel)flowLayoutPanel1.Controls[--pageIndex];

            pagenow.Active();
        }
        private void Page_Direction_Click(object sender, EventArgs e)
        {
            PageLabel click = sender as PageLabel;
            Direction direction = (Direction)click.Tag;


            (bool, int) result = paginationService.ChangePage(direction);
            if (!result.Item1)
            {
                PageNow(result.Item2);
                return;
            }
            List<int> Indexlist = paginationService.Pagegenerate(direction);       
            PageGenerate(Indexlist);
            PageNow(result.Item2);

            PageChanged?.Invoke(paginationService.PageIndex);
        }
       
        private void PageNumber_Click(object sender, EventArgs e)
        {
            if (pagenow != null)
            {
                pagenow.Reset();
            }
            pagenow = sender as PageLabel; //(PageLabel)sender;
            paginationService.SetPageNumber(int.Parse(pagenow.Text));
            PageNow(int.Parse(pagenow.Text));

            PageChanged?.Invoke(paginationService.PageIndex);

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
