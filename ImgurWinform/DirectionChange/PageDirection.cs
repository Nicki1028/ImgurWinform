using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinform
{
    internal abstract class PageDirection
    {      
        public abstract (bool, int) Change(int MaxPage, int pageIndex, int paginationCount);
        public abstract List<int> Generate(int MaxPage, int pageIndex, int paginationCount, int start=0, int end=0);

    }
}
