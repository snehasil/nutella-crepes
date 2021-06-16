using System;
using System.Collections.Generic;
using System.Text;

namespace nutella_crepes
{
    class intManit
    {
        private int[] integers;
        public intManit(int[] o)
        {
            for(int i = 0; i < o.Length; i++)
            {
                integers[i] = o[i];
            }
        }
        void ReturnInputs() {}
        void ReturnEvenInputs() {}
        void ReturnOddInputs() { }
        void Return5thInput() { }
        void ReturnSum() { }
        void ReturnDivisibleBy3(){}
    }
}
