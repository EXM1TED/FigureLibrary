using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class GetAreaFigure
    {
        public static double GetArea(IQuadrilateral figure)
        {
            double area = 0;
            if (figure.GetType() == typeof(Square))
            {
                area = Math.Pow(figure.SideA, 2);
            }
            if (figure.GetType() == typeof(Rectangle))
            {
                area = figure.SideA * figure.SideB;
            }
            return area;
        }

        public static double GetArea(ITringle figure)
        {
            double halfMeter = (figure.SideA + figure.SideB + figure.SideC) / 2; // полупериметер
            double area = Math.Sqrt(halfMeter * (halfMeter - figure.SideA) * (halfMeter - figure.SideB) * (halfMeter - figure.SideC)); // Формула Герона
            return area;
        }
    }
}
