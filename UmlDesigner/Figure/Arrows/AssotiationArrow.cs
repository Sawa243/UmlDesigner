

using System.Drawing;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure
{
    class AssotiationArrow: AbstractArrow
    {
        public AssotiationArrow(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
        }
    }
}
