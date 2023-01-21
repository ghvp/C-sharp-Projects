using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Vivienne";
            //string quote = "The man said \"hello\", vivi \n Hello on a new line \n \t hello on a tab";
            //string fileName = @"C:\Users\Vivienne";

            //bool trueOrFalse = name.Contains("v");
            //trueOrFalse = name.EndsWith("v");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.ReadLine();


            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Vivienne");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
