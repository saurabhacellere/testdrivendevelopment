using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class MathLibrary
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Division(int v1, int v2)
        {
            return v1 / v2;
        }

        public int SubtractionNoMinusResult(int v1, int v2)
        {
            if(v1 - v2 < 0)
            {
                throw new SubtractionNegativeErrorException();
            }
            return v1 - v2;
        }
    }
}
