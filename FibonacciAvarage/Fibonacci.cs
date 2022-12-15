using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciAvarage
{
    public class Fibonacci
    {
        public Fibonacci()
        {
        }

        int Fib(int level)
        {
            if (level == 1 || level == 0)
                return 0;
            if (level == 2)
                return 1;
            return Fib(level - 1) + Fib(level - 2);
        }

        public double Avarage(double level)
        {
            double sum = 0;

            for (int i = 0; i <= level; i++)
            {
                sum = sum + Fib(i);
            }

            return sum / level;
        }
    }
}
