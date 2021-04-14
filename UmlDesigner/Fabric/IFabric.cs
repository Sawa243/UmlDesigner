using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using UmlDesigner.Figure;

namespace UmlDesigner.Fabric
{
    interface IFabric
    {
        //AbstractArrow GetArrow(Pen pen, Point [] points);
        AbstractArrow GetArrow(Pen pen, List<Point> points);
    }
}
