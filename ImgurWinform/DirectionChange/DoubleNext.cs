using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinform
{
    internal class DoubleNext:PageDirection
    {
        public override (bool, int) Change(int MaxPage, int pageIndex, int paginationCount)
        {
            if (pageIndex + paginationCount <= MaxPage)
            {
                pageIndex += paginationCount;
            }
            else
            {
                pageIndex = MaxPage;
            }
            return (true, pageIndex);
        }

        public override List<int> Generate(int MaxPage, int pageIndex, int paginationCount, int start, int end)
        {
            List<int> pageIndexlist = new List<int>();
            if (pageIndex % paginationCount == 0)
            {
                end = pageIndex;
                start = end - paginationCount + 1;
            }
            else
            {
                start = pageIndex - (pageIndex % paginationCount) + 1;
                end = pageIndex - (pageIndex % paginationCount) + 5 <= MaxPage ? pageIndex - (pageIndex % paginationCount) + 5 : MaxPage;
            }

            for (int i = start; i <= end; i++)
            {
                pageIndexlist.Add(i);
            }
            return pageIndexlist;
        }
    }
}
