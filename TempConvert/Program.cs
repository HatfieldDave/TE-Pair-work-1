using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greet the usesr and tell them this is a temperature converter
            Console.WriteLine("Welcome to the Temperature Converter tool!");
            //Ask the user to enter a temperature in whole numbers
            Console.Write("Please enter a temperature in whole numbers: ");
            string value = Console.ReadLine();

            int tempInput = int.Parse(value);

            //Ask the user if they entered the temperature in Farenheit (F) or Celsius (C)
            Console.Write("Is your number in farenheit (F) or celsius (C)?");
            string index = Console.ReadLine();


            if (index.ToUpper() == "F")
            {
                double convertedTemp = (tempInput - 32) / 1.8;
                Console.WriteLine("The temperature " + tempInput.ToString("F1") + " farenheit converts to " + convertedTemp.ToString("F1") + " celsius");
                // .ToString("F1") formats to a single decimal
            }
            else
                if (index.ToUpper() == "C")
            {
                double convertedTemp = (tempInput * 1.8) + 32;
                Console.WriteLine("The temperature " + tempInput.ToString("F1") + " celsius converts to " + convertedTemp.ToString("F1") + " farenheit");
            }
        }
        
    }
}
