using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternLab
{
   public class Square:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw-->Square.");
        }
    }
}
