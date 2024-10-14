using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Triangle : ITringle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double lenghtSideA,
                double lenghtSideB,
                double lenghtSideC)
        {
            SideA = lenghtSideA;
            SideB = lenghtSideB;
            SideC = lenghtSideC;
        }

        public bool IsTriangleRightAngle()
        {
            return Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2); // проверка осуществляется по теореме Пифагора
        }

        public double GetArea()
        {
            double halfMeter = (this.SideA + this.SideB + this.SideC) / 2; // полупериметер
            double area = Math.Sqrt(halfMeter * (halfMeter - this.SideA) * (halfMeter - this.SideB) * (halfMeter - this.SideC)); // Формула Герона
            return area;
        }
    }
}
