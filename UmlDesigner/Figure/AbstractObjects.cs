using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Figure
{
   public abstract class AbstractObjects: AbstractAllFigurs
    {
        
        public AbstractObjects()
        {
            _action = new DrawForms();
            _figureType = 0;
        }
        protected override List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(StartPoint);
            points.Add(EndPoint);
            return points;
        }
        public override void Draw(Graphics graphics)
        {
            _action.Draw(graphics,_pen, GetPoints());
        }
    }
}
