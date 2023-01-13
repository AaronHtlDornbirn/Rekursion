using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    public class Fakultät
    {
        public static int GetFakultät(int number)
        {
            if(number == 1)
            {
                return number;
            }
            else
            {
                return number * GetFakultät(number - 1);
            }
        }
    }
}
