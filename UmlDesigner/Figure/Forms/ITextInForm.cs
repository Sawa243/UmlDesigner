using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner.Figure.Forms
{
   public interface ITextInForm
    {
        void TextRedactor(Graphics graphics, Pen pen,Point point);
    }
}
