using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinform.DirectionChange
{
    internal class ChangeNumber : PageDirection
    {
        public override (bool, int) Change(int MaxPage, int pageIndex, int paginationCount)
        {
            if (pageIndex < 1)
            {
                pageIndex = 1;
            }
            else if (pageIndex > MaxPage)
            {
                pageIndex = MaxPage;
            }
            return (true, pageIndex);

        }

        public override List<int> Generate(int MaxPage, int pageIndex, int paginationCount, int start = 0, int end = 0)
        {
            throw new NotImplementedException();
        }
    }
}
