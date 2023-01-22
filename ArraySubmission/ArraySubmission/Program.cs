using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //creating a string array
        string[] myArray = { "this", "is", "an", "array" };
        Console.WriteLine("Please select an index from the array (0 - 3)");
        int guess = Convert.ToInt32(Console.ReadLine()); //casting the user input into var to make it easy for comparison

        if (guess > 3)
        {
            Console.WriteLine("index does not exist");
        }
        else if (0 > guess) 
        {
            Console.WriteLine("there are no negative indexes");
        }
        else
        {
            Console.WriteLine(myArray[guess]);
        }

        //creating an integer array 
        int[] fiveArray = { 5, 10, 15, 20 };
        Console.WriteLine("Select an index from the array");
        int numIndex = Convert.ToInt32(Console.ReadLine());

        if (numIndex > 3)
        {
            Console.WriteLine("index does not exist");
        }
        else if (0 > numIndex) 
        {
            Console.WriteLine("you cannot select a negative index");
        }
        else
        {
            Console.WriteLine(fiveArray[numIndex]);
        }

        //List of strings
        List<string> wordList = new List<string>();
        //Adds items to the list
        wordList.Add("zero");
        wordList.Add("one");
        wordList.Add("two");
        wordList.Add("three");
        //prompting the user to select an index
        Console.WriteLine("Select an index from the list (0 - 3)");
        //converts user input into an integer and stores it
        int wordIndex = Convert.ToInt32(Console.ReadLine());

        //if the user inputs an index greater than 3 then print
        //"index does not exist'
        if (wordIndex > 3)
        {
            Console.WriteLine("Index does not exist");
        }
        //if the user inputs an index that does exist, print out
        //the result
        else if (0 > wordIndex) 
        {
            Console.WriteLine("you can't select a negative index. try again");
        }
        else
        {
            Console.WriteLine(wordList[wordIndex]);
        }
        Console.ReadLine();

    }
}

