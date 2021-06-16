using System;

namespace nutella_crepes
{
    class TestIntManit
    {
        static void Main(string[] args)
        {
            int userInput = -1;
            Console.WriteLine("How many integers do you want to input?");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] integers = new int[arrayLength];
            int menu = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine("Enter an integer: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                integers[i] = userInput;
            }
            intManit test = new intManit(integers);
            do
            {
                Console.WriteLine("-1 to quit, 1 to display the whole list of input, 2 to display every even number, 3 to display every odd number, 4 to display every 5th number, 5 to display the sum of integers, and 6 to display every number divisible by 3");
                menu = Convert.ToInt32(Console.ReadLine());
            }
            while (menu != -1);
        }
    }
}
