using System.Drawing;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Fabric
{
    class FormObjectFactory:IFactory
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new FormObject(pen, new DrawForms());
        }
    }
}
