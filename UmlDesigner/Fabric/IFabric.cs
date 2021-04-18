
using System.Drawing;
using UmlDesigner.Figure;

namespace UmlDesigner.Fabric
{
    interface IFabric
    {
        AbstractArrow GetArrow(Pen pen);
        AbstractObjects GetObjects();
    }
}

