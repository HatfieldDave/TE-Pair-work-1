using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string userNums = Console.ReadLine(); // collects user numbers

            string[] userNumsString = userNums.Split(" "); // splits numbers 5 1234 67 123

            int[] userNumsInt = new int[userNumsString.Length];
            for (int i = 0; i < userNumsString.Length; i++)
            {
                userNumsInt[i] = int.Parse(userNumsString[i]);
                Console.WriteLine(userNumsInt[i] + " in binary is " + Convert.ToString(userNumsInt[i], 2));
            }



        }

    }
}




