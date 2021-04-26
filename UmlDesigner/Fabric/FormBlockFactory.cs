using System.Drawing;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Fabric
{
    class FormBlockFactory : IFactory
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new FormBlock(pen, new DrawForms());
        }
    }
}
