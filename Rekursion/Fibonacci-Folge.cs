using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    public class FibonacciFolge
    {
        public int GetFibonacciFolge(int number)
        {
            if ((number == 0) || (number == 1))
            {
                return number;
            }
            else
            {
                return GetFibonacciFolge(number - 1) + GetFibonacciFolge(number - 2);
            }             
        }
    }
}
