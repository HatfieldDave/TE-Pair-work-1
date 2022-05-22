using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greet the usesr and tell them this is a linear converter
            Console.WriteLine("Welcome to the Linear Converter tool! This tool will convert meters to feet / feet to meters");
            //Ask the user to enter a temperature in whole numbers
            Console.Write("Please enter a length in whole numbers: ");
            string value = Console.ReadLine();

            int lengthInput = int.Parse(value);

            //Ask the user if they entered the length is in feet (F) or meters (M)
            Console.Write("Is your number in feet (F) or meters (M)?");
            string index = Console.ReadLine();


            if (index.ToUpper() == "F")
            {
                double convertedLength = lengthInput * 0.3048;
                Console.WriteLine("The length " + lengthInput.ToString("F1") + " feet converts to " + convertedLength.ToString("F1") + " meters");
                // .ToString("F1") formats to a single decimal
            }
            else
                if (index.ToUpper() == "M")
            {
                double convertedLength = lengthInput * 3.2808399;
                Console.WriteLine("The length " + lengthInput.ToString("F1") + " meters converts to " + convertedLength.ToString("F1") + " feet");

            }
        }
    }

}
