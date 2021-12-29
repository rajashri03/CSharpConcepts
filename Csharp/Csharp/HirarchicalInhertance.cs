using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class HirarchicalInhertance//class name polygon
    {
        /// <summary>
        /// method to calculate
        /// </summary>
        /// <param name="lenght"></param>
        /// <param name="sides"></param>
        public void CalculatePerimeter(int lenght,int sides)
        {
            int result = lenght * sides;
            Console.WriteLine($"Perimeter:{result}");
        }
    }
    public class Squre:HirarchicalInhertance
    {
        public int lenght = 200;
        public int sides = 4;
        public void CalculateArea()
        {
            int area = lenght * lenght;
            Console.WriteLine($"Area of squre:{area}");
        }
    }
    public class Rectangle:HirarchicalInhertance
    {
        public int lenght = 400;
        public int breadth = 200;
        public int sides = 4;
        public void CalculateArea()
        {
            int area = lenght * breadth;
            Console.WriteLine($"Area of rectangle{area}");
        }
    }
}
