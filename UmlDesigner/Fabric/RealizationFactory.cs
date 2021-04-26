using System.Drawing;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Arrows;

namespace UmlDesigner.Fabric
{
    public class RealizationFactory : IFactory
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new RealizationArrow(pen, new Drawing());
        }
    }
}
