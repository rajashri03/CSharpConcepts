using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Encapsulation
    {
        string numType;
        public string Numtype
        {
            get
            {
                return numType;
            }
            set
            {
                if(Convert.ToInt16(value)%2==0)
                {
                    numType = "Even";
                }
                else
                {
                    numType = "ODD";
                }
            }
        }
    }
}
