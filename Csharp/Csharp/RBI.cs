using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    //Multilevel Inheritance
    public class RBI
    {
        public float rate_rbi = 6.5f;
        public float CalculateBalnce_RBI(int amount,int years)
        {
            return amount + (amount * rate_rbi * years) / 100;
        }
    }
    public class SBI : RBI
    {
        public float rate_sbi = 7f;
        public float CalculateBalnce_SBI(int amount,int years)
        {
            return amount + (amount * rate_sbi * years) / 100;
        }
    }
    public class canera:SBI
    {
        public float rate_canera = 4.5f;
        public float CaluclateBalnce_canera(int amount,int years)
        {
            return amount + (amount * rate_canera * years) / 100;
        }
    }
}
