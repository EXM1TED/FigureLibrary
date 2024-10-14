using FigureLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class FigureLibraryTests
    {
        [TestMethod]
        public void GetArea_FromGetAreaFigure_RectangleSides_4_And_8_Return_32()
        {
            IQuadrilateral figure = new Rectangle(4, 8);
            double expected = 32;
            double actual = GetAreaFigure.GetArea(figure);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetArea_FromGetAreaFigure_Triangle_Sides_3_4_5_Return_6()
        {
            ITringle tringle = new Triangle(3, 4, 5);
            double expected = 6;
            double actual = GetAreaFigure.GetArea(tringle);

            Assert.AreEqual(expected, actual);
        }
    }
}
