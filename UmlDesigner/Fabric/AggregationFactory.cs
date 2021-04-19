using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Arrows;

namespace UmlDesigner.Fabric
{
    public class AggregationFactory: IFabric
    {
        public AbstractArrow GetArrow(Pen pen)
        {
            return new AggregationArrow(pen, new Drawing());
        }
    }
}
