using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

       Console.Write("How many days?\n> ");
            string userInput = Console.ReadLine();
            int daysAmount = Convert.ToInt32(userInput);

            int daysInSeconds = ((daysAmount*24)*60)*60;

            Console.WriteLine(daysInSeconds);
            Console.ReadKey();

    }
  }
}
