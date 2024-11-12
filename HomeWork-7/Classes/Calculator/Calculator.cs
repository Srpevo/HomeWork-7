using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7.Classes.Calculation
{
    internal class Calculator<T> where T : struct
    {
        public int Fold(T A, T B)
        {
            return (dynamic)A + (dynamic)B;
        }

        public int Subtraction(T A, T B)
        {
            return (dynamic)A - (dynamic)B;
        }
    }
}
