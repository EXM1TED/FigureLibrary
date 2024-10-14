using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Square : IQuadrilateral
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }

        public Square(int lenghtSide)
        {
            SideA = lenghtSide;
            SideB = lenghtSide;
            SideC = lenghtSide;
            SideD = lenghtSide;
        }


        public  double GetArea()
        {
            return Math.Pow(SideA, 2);
        }
    }
}
