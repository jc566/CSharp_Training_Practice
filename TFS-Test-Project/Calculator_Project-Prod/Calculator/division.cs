using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class division
    {
        public float Divide(float num1, float num2)
        {
            float c;

            if (num2 != 0)

            {

                c = num1 / num2;
            }
            else
            {

                num2 = 1;
                c = num1 / num2;
            }
            return c;
        }
    }
}
