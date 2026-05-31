using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinform
{
    internal class Previous:PageDirection
    {
        
        public override (bool, int) Change(int MaxPage, int pageIndex, int paginationCount)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
            }
            if (pageIndex % paginationCount != 0)
            {
                return (false, pageIndex);
            }
            return (true, pageIndex);
        }
        public override List<int> Generate(int MaxPage, int pageIndex, int paginationCount, int start, int end)
        {
            List<int> pageIndexlist = new List<int>();
            start = pageIndex - paginationCount > 0 ? pageIndex - paginationCount + 1 : 1;
            end = pageIndex;
            for (int i = start; i <= end; i++)
            {
                pageIndexlist.Add(i);
            }
            return pageIndexlist;
        }

    }
}
