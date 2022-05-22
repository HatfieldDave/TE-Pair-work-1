using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string fibString = Console.ReadLine();
            int fibNum = int.Parse(fibString);
            int fibCurrent = 1;
            int fibPrevious = 0;
            int fibNext = 0;

            Console.Write(fibPrevious + ", " + fibCurrent + ", ");
            fibNext = fibCurrent + fibPrevious;

            while (fibNext <= fibNum)
            {
                Console.Write(fibNext + ", ");
                fibPrevious = fibCurrent;
                fibCurrent = fibNext;
                fibNext = fibPrevious + fibCurrent;
            }
        }
    }
}
