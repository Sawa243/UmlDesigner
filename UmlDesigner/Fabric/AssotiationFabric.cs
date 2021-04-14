using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Fabric
{
    public class AssotiationFabric : IFabric
    {
        public AbstractArrow GetArrow(Pen pen, List<Point> points)
        {
            return new AssotiationArrow(pen, points,new Drawing());
        }
    }
}
