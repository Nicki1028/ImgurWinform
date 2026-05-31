using ImgurWinform.DirectionChange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinform
{
    internal class DirectionChangeFactory
    {
        public static PageDirection GetPageDirection(Direction direction)
        {
            PageDirection dc = null;
            switch (direction)
            {
                case Direction.Next:
                    dc = new Next();
                    break;
                case Direction.Previous:
                    dc = new Previous();
                    break;
                case Direction.DoubleNext:
                    dc = new DoubleNext();
                    break;
                case Direction.DoublePrevious:
                    dc = new DoublePrevious();
                    break;
                case Direction.ChangeNumber:
                    dc = new ChangeNumber();
                    break;
            }
            return dc;

        }
    }
}
