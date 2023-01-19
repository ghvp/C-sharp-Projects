using System;

namespace PriceQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            //Prompting user for package weight 
            Console.WriteLine("Please enter in your package weight");
            int acceptedWeight = 50;
            int weight = Convert.ToInt32(Console.ReadLine());

            //Creating an if statement that will display text if the parcel is too heavy to ship
            if (weight > acceptedWeight) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a nice day");
                Environment.Exit(0);
            }

            //Prompting user for package width,height and length
            Console.WriteLine("What is the width of your package");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            //Package height
            Console.WriteLine("What is the height of your package");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            //Package length
            Console.WriteLine("What is the length of your package");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //Checking to see if the package dimensions total greater than 50
            //and if so, will display a message letting the user know 
            //their package is too large to be shipped

            //Variable to store the package dimensions 
            int totalDimensions = packageHeight + packageLength + packageWidth;
            //Variable that holds the max for dimensions 
            int maxDimensions = 50;
            //if statement that will display a message to the console if 
            //package dimensions go over the max limit
            if (totalDimensions > maxDimensions) 
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
                Environment.Exit(0);
            }

            //Multiplying the package dimensions 
            int packageDimensions = packageWidth * packageHeight * packageLength;
            //Stores the multiplied dimensions into a var dimensionAndWeight
            // packageDimensions is then multiplied by weight
            int dimensionAndWeight = packageDimensions * weight;
            //price is calculated by dividing the dimensionAndWeight variable by 100
            decimal Calculatedprice = dimensionAndWeight / 100m;
            //displaying the quote to the user in dollar amount
            Console.WriteLine("Your estimated total for shipping this package is: " + Calculatedprice);

        }
    }
}
