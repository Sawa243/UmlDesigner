
using System.Drawing;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Fabric
{
    public class AssotiationFabric : IFabric
    {
        public AbstractArrow GetArrow(Pen pen)
        {
            return new AssotiationArrow(pen, new Drawing());
        }
        public AbstractObjects GetObjects()
        {
            return new FormClass();
        }
    }
}
