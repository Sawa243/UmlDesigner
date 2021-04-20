﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Arrows;

namespace UmlDesigner.Fabric
{
    class CompositionFactory : IFabric
    {
        public AbstractAllFigurs GetElement(Pen pen)
        {
            return new CompositionArrow(pen, new Drawing());
        }
    }
}
