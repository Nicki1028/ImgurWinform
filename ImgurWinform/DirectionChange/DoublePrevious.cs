using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinform
{
    internal class DoublePrevious:PageDirection
    {

        public override (bool, int) Change(int MaxPage, int pageIndex, int paginationCount)
        {
            if (pageIndex - paginationCount > 0)
            {
                pageIndex -= paginationCount;
            }
            else
            {
                pageIndex = 1;
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
                end = pageIndex - (pageIndex % paginationCount) + 5;
                start = pageIndex - (pageIndex % paginationCount) + 1 <= 0 ? 1 : pageIndex - (pageIndex % paginationCount) + 1;
            }

            for (int i = start; i <= end; i++)
            {
                pageIndexlist.Add(i);
            }
            return pageIndexlist;
        }
    }
  
}
