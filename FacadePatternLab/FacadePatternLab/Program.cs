using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMake=new ShapeMaker();
            shapeMake.DrawCircle();
            shapeMake.DrawRectangle();
            shapeMake.DrawSquare();
            Console.ReadKey();
        }
    }
}
