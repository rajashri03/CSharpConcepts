using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Inheritance  //Base Class
    {
        protected int a, b;
        public void Adition()
        {
          
            Console.WriteLine("Enter First Number:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            b = Convert.ToInt16(Console.ReadLine());

        }
    }
    public class Add: Inheritance//Class Add – Derived Class
    {
        int Sum;
        public void Adddata()
        {
          
            Sum = a + b;
            Console.WriteLine("Adition is:" + Sum);
        }
    }
}
