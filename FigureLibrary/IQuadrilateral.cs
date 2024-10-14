using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public interface IQuadrilateral
    {
         double SideA { get; set; }
         double SideB { get; set; }
         double SideC { get; set; }
         double SideD { get; set; }
    }
}
