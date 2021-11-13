using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MlInterfaceHierarchy
{
    interface IShape: IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
    interface IDrawable
    {
        void Draw();
    }
    interface IPrintable
    {
        void Print();
        void Draw();
    }
}
