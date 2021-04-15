
using System.Drawing;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Fabric
{
    public class AssotiationFabric : IFabric
    {
        public AbstractArrow GetArrow(Pen pen)
        {
            return new AssotiationArrow(pen, new Drawing());
        }
    }
}
