using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("six part assignment");

        //step 1
        //Adding a one dimensional array of strings
        string[] step1Array = new string[5];
        Console.WriteLine("Please enter in some values");
        //Creating a loop that will iterate through each string
        for (int i = 0; i < step1Array.Length; i++ )
        {
            //asking the user to input some text
            step1Array[i] = Console.ReadLine();

        }

        //a second loop that will print off each string in the array
        for (int i = 0; i < step1Array.Length; i++)
        {
            Console.WriteLine("Values input by user " + step1Array[i]);
        }
        Console.ReadLine();


        //step 2
        //creating the infinite loop
        //while (true)
        //{
        //    Console.WriteLine("true!!!");
        //}

        //fixing the while loop
        //Gave a conditon for the loop to check for
        bool j = true;
        while (j) 
        {
            j = false;
            Console.WriteLine("j is not true");

        }

        //step 3
        //using < as the operator
        
        for (int r=0; r<5; r++) 
        {
            Console.WriteLine(r);
        }

        //using <= operator
        for (int h = 0; h <= 8; h++)
        {
            Console.WriteLine(h);
        }


        //step 4
        List<string> names = new List<string>();
        names.Add("Vivienne");
        names.Add("Hannah");
        names.Add("Jane");
        Console.WriteLine("Please select the following options Vivienne, Hannah, Jane");
        string userInput = Console.ReadLine();
        for (int k = 0; k < names.Count; k++) 
        {
            if (names[k] == userInput) 
            {
                Console.WriteLine("Index " + k + " name: " + userInput);
                Console.ReadLine();
                break;
            }

            if (names.Contains(userInput) == false) 
            {
                Console.WriteLine("That isn't on the list :((");
            }
            Console.ReadLine();
        }

        //step 5
        List<string> colors = new List<string>();
        colors.Add("green");
        colors.Add("pink");
        colors.Add("beige");

        Console.WriteLine("Please pick a color! (green, pink, beige)");
        string userColor = Console.ReadLine();

        // Creating a loop that iterates through the list and displays
        // the item matching the user's input
        for (int z = 0; z < colors.Count; z++)
        {
            if (colors[z] == userColor)
            {
                Console.WriteLine("Index " + z + ": " + userColor);
                Console.ReadLine();
            }
            if (colors.Contains(userColor) == false)
            {
                Console.WriteLine(userColor + " is not on the list.");
            }
            Console.ReadLine();
        }


        //step 6
        List<string> letters = new List<string>() { "A", "B", "C", "C", "D" };
        List<string> duplicate = new List<string>();

        // Creating a loop that evaluates each item in the list and
        // displays a message showing the string and whether or not
        // it has already appeared in the list.
        foreach (string letter in letters)
        {
            if (duplicate.Contains(letter))
            {
                Console.WriteLine(letter + " - this item is a duplicate");
                System.Threading.Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine(letter + " - this item is unique");
                System.Threading.Thread.Sleep(500);
                duplicate.Add(letter);
            }

        }
        Console.ReadLine();
    } 
}

