using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSimulator
{
    internal class RollDice
    {
        // Here is the Roll method that receives a number of rolls from the program
        // It will return an array of integers
        public int[] Roll(int numRolls)
        {
            // use random
            Random random = new Random();

            // Create a new array of results that has a length of 11
            int[] results = new int[11];

            // Create a loop to roll two dice numRolls times
            for (int i = 0; i < numRolls; i++)
            {
                // Roll each dice (random number between 1 and 7)
                int dice1 = random.Next(1, 7);

                int dice2 = random.Next(1, 7);

                // Sum the two rolls together
                int sum = dice1 + dice2;

                // Add the results to the array
                results[sum - 2]++;
            }

            // Return the array of results
            return results;

        }
    }
}
