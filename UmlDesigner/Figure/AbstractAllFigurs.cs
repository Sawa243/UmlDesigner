using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure
{
   public abstract class AbstractAllFigurs
    {
        protected IAction _action;
        protected Pen _pen;
        public int _figureType;
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public AbstractAllFigurs()
        {
            _action = new Drawing();
        }
        protected abstract List<Point> GetPoints();

        public abstract void  Draw(Graphics graphics);
    }
}
