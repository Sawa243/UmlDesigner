
using System.Drawing;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Fabric
{
    public class AssotiationFabric : IFabric
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new AssotiationArrow(pen, new Drawing());
        }
    }
}
