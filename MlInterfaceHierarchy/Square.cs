using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlInterfaceHierarchy
{
    class Square : IShape
    {
        void IDrawable.Draw()
        {
            //Draw on screen
        }

        void IPrintable.Draw()
        {
            //Draw to printer
        }

        int IShape.GetNumberOfSides()
        {
            return 4;
        }

        void IPrintable.Print()
        {
            //Print
        }
    }
}
