using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UmlDesigner
{
    interface IDrawable
    {
        void Draw(Graphics graf, Pen pen);
    }
}
