using System.Drawing;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Arrows;

namespace UmlDesigner.Fabric
{
    class CompositionFactory : IFactory
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new CompositionArrow(pen, new Drawing());
        }
    }
}
