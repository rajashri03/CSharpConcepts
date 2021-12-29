using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Inheritance  //Base Class
    {
        public int a, b;
        public void Adition(int a,int b)
        {
            this.a = a;
            this.b = b;

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
