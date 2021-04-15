using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner
{
    public class DrowArea
    {
        private static DrowArea _drow;

        private DrowArea()
        {

        }
        public static DrowArea GetLake()
        {
            if (_drow is null)
            {
                _drow = new DrowArea();
            }
            return _drow;
        }
    }
}
