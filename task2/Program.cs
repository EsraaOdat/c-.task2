using System;
using System.ComponentModel;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1

            Console.Write("Enter the first integer: ");
            int firstNumber = int.Parse(Console.ReadLine());

            
            Console.Write("Enter the second integer: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int smallerNumber = firstNumber < secondNumber ? firstNumber : secondNumber;
            Console.WriteLine("The smaller number is: " + smallerNumber);




            //#2
            Console.Write("Enter the num: ");

            int x = int.Parse(Console.ReadLine());
            if (x > 0) { Console.WriteLine("The sign is +"); }
            else
            {
                Console.WriteLine("The sign is -");
                    }








            //#3

            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int c = int.Parse(Console.ReadLine());

            int[] numbers = { a, b, c };
             Array.Sort(numbers);
            Console.WriteLine($"{numbers[2]} {numbers[1]} {numbers[0]}");




            //#4


            int[] XXXX = { -5, -2, -6 ,0,-1};
            Array.Sort(XXXX);
            Console.WriteLine($" max of five numbers: {XXXX[XXXX.Length-1]} ");







            //#5
        


        Console.Write("Enter speed in kilometers per hour(km/h) : ");
        double v = double.Parse(Console.ReadLine());

        double milesPerHour = v * 0.621371;

        Console.WriteLine($"{milesPerHour}  miles per hour (mph).");







            //#6
            Console.Write("Input hours:  ");

            int hours = int.Parse(Console.ReadLine());
            Console.Write("Input minutes:  ");

            int minutes = int.Parse(Console.ReadLine());

            int calculator = hours*60;
            Console.WriteLine($"Total: {calculator + minutes} minutes.");





            //#7

            Console.Write("Input minutes: ");
            int totalMinutes = int.Parse(Console.ReadLine());

            int hours1 = totalMinutes / 60;
            int minutes1 = totalMinutes % 60;

            Console.WriteLine($"{hours} Hours, {minutes} Minutes");





            //#8
            string[] strings = { "strings1", "strings2", "strings3", "strings4", "strings5" };

            Console.WriteLine($"{strings[0]}   length: {strings[0].Length}");
            Console.WriteLine($"{strings[1]}   length: {strings[1].Length}");
            Console.WriteLine($"{strings[2]}   length: {strings[2].Length}");
            Console.WriteLine($"{strings[3]}   length: {strings[3].Length}");
            Console.WriteLine($"{strings[4]}   length: {strings[4].Length}");

            Console.WriteLine($"Array length: {strings.Length}");
        }
    }

}
