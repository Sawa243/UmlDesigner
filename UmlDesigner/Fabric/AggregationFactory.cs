using System.Drawing;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Arrows;

namespace UmlDesigner.Fabric
{
    public class AggregationFactory : IFactory
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new AggregationArrow(pen, new Drawing());
        }
    }
}
