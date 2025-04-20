using System;

class Program
{
    static void Main()
    {
        // Display a welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter the package weight
        Console.WriteLine("Please enter the package weight:");
        // Read input from user and convert to a decimal number
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if the weight exceeds the maximum allowed
        if (weight > 50)
        {
            // Display an error message if the weight is too heavy
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program early
        }

        // Prompt the user to enter the package width
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Prompt the user to enter the package height
        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Prompt the user to enter the package length
        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Calculate the total of the dimensions
        decimal dimensionTotal = width + height + length;

        // Check if the combined dimensions exceed the allowed size
        if (dimensionTotal > 50)
        {
            // Display an error message if the package is too big
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program early
        }

        // Calculate the quote: (width * height * length * weight) / 100
        decimal volume = width * height * length;
        decimal quote = (volume * weight) / 100;

        // Display the calculated quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
    }
}
