using System;
using System.Linq;

class DiceRoller
{
    static void Main()
    {
        int[] counts = new int[13]; // an array to keep track of the number of times each total is thrown

        Console.Write("Enter the number of times to roll the dice: ");
        int rolls = int.Parse(Console.ReadLine());

        Random rand = new Random();

        for (int i = 0; i < rolls; i++)
        {
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);

            int total = die1 + die2;
            counts[total]++;
        }

        // print the histogram
        Console.WriteLine("Total Percentage\n");
        for (int i = 2; i <= 12; i++)
        {
            double percentage = (counts[i] / (double)rolls) * 100;
            Console.WriteLine("{0}: {1}% {2}", i, percentage, new string('*', (int)percentage));
        }
        Console.Write("\n" + "Thanks for playing! Come again some time soon!" + "\n");

    }
}
