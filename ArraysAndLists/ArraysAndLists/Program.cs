﻿using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<string> intList = new List<string>();

        intList.Add("hello");
        intList.Add("vivienne");
        intList.Remove("vivienne");

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        ////easiest way to initialize and create an array
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;



        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}

