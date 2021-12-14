using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    #region Homework - Fibonucci
    class Fibonacci
    {
        public int a = 1;
        public int b = 1;
        public int count = 0;

        public void Fibonation(int num)
        {
            for (int i = 0; i < num; i++)
            {
                a = b;
                b = count;
                count = a + b;
                Console.WriteLine(count);
            }
        }


    }
    #endregion
}
