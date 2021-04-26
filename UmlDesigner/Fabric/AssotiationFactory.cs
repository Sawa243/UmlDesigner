using System.Drawing;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;


namespace UmlDesigner.Fabric
{
    public class AssotiationFactory : IFactory
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new AssotiationArrow(pen, new Drawing());
        }
    }
}
