
using System.Drawing;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Arrows;

namespace UmlDesigner.Fabric
{
    public class InheritanceFactory:IFabric
    {
        public AbstractArrow GetArrow(Pen pen)
        {
            return new InheritanceArrow(pen, new Drawing());
        }
    }
}
