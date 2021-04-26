using System.Drawing;
using UmlDesigner.Figure;

namespace UmlDesigner.Fabric
{
    interface IFactory
    {
        AbstractAllFigurs GetElement(Pen pen);
    }
}

