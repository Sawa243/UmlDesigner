using System.Drawing;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Fabric
{
    class FormInterfaceFactory : IFactory
    {
      public AbstractAllFigurs GetElement(Pen pen)
      {
            return new FormInterface(pen, new DrawForms());
      }
    }
}
