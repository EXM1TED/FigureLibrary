using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Rectangle : IQuadrilateral
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }  

        public Rectangle(double lenghtSideX, double lenghtSideY)
        {
            SideA = lenghtSideX;
            SideB = lenghtSideY;
            SideC = lenghtSideX;
            SideD = lenghtSideY;
        }

        public double GetArea()
        {
            return SideA * SideC;
        }
    }
}
