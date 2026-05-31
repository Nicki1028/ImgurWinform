using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurWinform
{
    internal class PaginationService
    {
        private int pageIndex = 0;
        public int PageIndex { get { return this.pageIndex; } }

        private int MaxPage;
        private int paginationCount;

        public PaginationService(int total, int perPageCount, int PaginationCount)
        {
            MaxPage = (total / perPageCount) + 1;
            this.paginationCount = PaginationCount;
        }      
        public (bool, int) ChangePage(Direction direction)
        {
            PageDirection pageDirection = DirectionChangeFactory.GetPageDirection(direction);
            var result = pageDirection.Change(MaxPage, pageIndex, paginationCount);
            pageIndex = result.Item2;
            return result;
            
        }      
        public List<int> Pagegenerate(Direction direction)
        {
            PageDirection pageDirection = DirectionChangeFactory.GetPageDirection(direction);
            return pageDirection.Generate(MaxPage, pageIndex, paginationCount, 0, 0);    
        }       
        public void SetPageNumber(int pagenumber)
        {
            PageDirection pageDirection = DirectionChangeFactory.GetPageDirection(Direction.ChangeNumber);
            var result = pageDirection.Change(MaxPage, pagenumber, paginationCount);
            pageIndex = result.Item2;
          
        }
    }
}
