using System;

namespace While
{
    class WhileTest
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine("Current value of n is {0}",n);
                n++;
            }
            
        }
    }
}
