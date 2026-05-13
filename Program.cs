using System;

namespace ArraysCsharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // int age = 28;
            // string name = "ema";
            //
            // int[] numbers = new int [5];
            //
            // numbers[0] = 10;
            // numbers[2] = 99;
            //
            // Console.WriteLine(numbers[0]);
            // Console.WriteLine(numbers[2]);
            //
            // Console.WriteLine(numbers.Length);
            //
            // int count = 0;
            // while (count < numbers.Length)
            // {
            //     numbers[count] = count * 10;
            //     count++;
            // }
            
            // string[] fruits = new string[3];
            //
            // int i = 0;
            // while (i < fruits.Length)
            // {
            //     Console.Write("Enter a fruit: ");
            //     fruits[i] = Console.ReadLine();
            //     i++;
            // }
            //
            // Console.WriteLine("Your fruits:");
            // foreach (string fruit in fruits)
            // {
            //     Console.Write(fruit + ", ");
            // }
            
            string[] pin = new string[4];

            int i = 0;
            
            Console.WriteLine("Please enter your pin, one number at a time.");
            while (i < pin.Length)
            {
                Console.Write("Enter your pin: ");
                pin[i] = Console.ReadLine();
                i++;
            }
            
            Console.WriteLine("Your PIN is: ");
            foreach (string pinTot in pin)
            {
                Console.Write(pinTot);
            }
        }
    }
}