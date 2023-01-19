using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number" : "You do not have an awesome favorite number";

            Console.WriteLine(result);

            //int roomTemperature = 70;

            //Console.WriteLine("Hi what is our name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi " + name + " what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("it is colder than room temperature");
            //}
            //else 
            //{
            //    Console.WriteLine("uhhhhh.. something went wrong");
            //} 

            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "it is room temp." : "it is not room temp";
            //Console.WriteLine(comparisonResult);

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature) 
            //{
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}
            Console.ReadLine();
        }
    }
}