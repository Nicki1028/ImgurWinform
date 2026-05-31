using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinform
{
    internal class Next:PageDirection
    {
        
        public override (bool, int) Change(int MaxPage, int pageIndex, int paginationCount)
        {
            if (pageIndex < MaxPage)
            {
                pageIndex++;
            }
            if (pageIndex % paginationCount != 1)
            {
                return (false, pageIndex);
            }
            return (true, pageIndex);
        }

        public override List<int> Generate(int MaxPage, int pageIndex, int paginationCount, int start, int end)
        {
            List<int> pageIndexlist = new List<int>();
            start = pageIndex;
            end = pageIndex + paginationCount < MaxPage ? (pageIndex + paginationCount) - 1 : MaxPage;
            for (int i = start; i <= end; i++)
            {
                pageIndexlist.Add(i);
            }
            return pageIndexlist;
        }
    }
}
