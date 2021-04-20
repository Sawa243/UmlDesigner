using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
