using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Forms
{
   public class FormClass : AbstractObjects
    {
        public FormClass (Pen pen,IAction action)
        {   
            _action = action;
            _pen = pen;
        }
    }
}
