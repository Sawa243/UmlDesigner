using System.Drawing;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Fabric
{
    public class FormsClasFactory : IFactory
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new FormClass(pen, new DrawForms());
        }
    }
}
