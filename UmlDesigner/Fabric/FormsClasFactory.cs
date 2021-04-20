﻿using System;
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
    public class FormsClasFactory : IFabric
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new FormClass(pen, new DrawForms());
        }
    }
}