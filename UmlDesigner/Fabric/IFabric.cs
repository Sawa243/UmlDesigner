
using System.Drawing;
using UmlDesigner.Figure;

namespace UmlDesigner.Fabric
{
    interface IFabric
    {
        AbstractAllFigurs GetElement(Pen pen);
    }
}

