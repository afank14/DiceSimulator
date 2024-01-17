// Added this so that I can call the Roll() method
using DiceSimulator;
public class Program
{
    private static void Main(string[] args)
    {
        // Create a variable for the number of rolls and for the output array
        int numRolls;
        int[] output;

        // Create an instance of the RollDice class
        RollDice rd = new RollDice();

        // Write the introduction and ask for the number of dice rolls
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
            "We are glad you are trying your luck here rather than in Vegas.\n\n" +
            "How many dice throws do you want to simulate?");

        // Receive input for the number of rolls and make it an integer
        numRolls = int.Parse(System.Console.ReadLine());

        // Make the output array the array of results returned from the rd.Roll method
        output = rd.Roll(numRolls);

        // Write the introduction to the results
        System.Console.WriteLine("\nDICE THROWING SIMULATOR RESULTS\n" +
            "Each '*' represents 1% of the total number of rolls\n" +
            "Total number of rolls is " + numRolls);

        // Call the PrintResults method to make the histogram
        PrintResults(output, numRolls);
    }

    // This is my PrintResults method that receives the results array and the number of rolls
    private static void PrintResults(int[] results, int numRolls)
    {
        // Create a loop for each of the possible sums of the two dice rolls
        for (int i = 2; i <= 12; i++)
        {
            // Create a percentage of rolls for each increment
            int percent = (results[i - 2] * 100) / numRolls;
            // Create a string of * based on the percent
            string asterisks = new string('*', percent);
            // Write the line of the number and its asterisks
            System.Console.WriteLine(i + ": " + asterisks);
        }

    }
}