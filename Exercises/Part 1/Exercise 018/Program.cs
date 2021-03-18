using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.Write("Give the first number!\n> ");
            string firstInput = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstInput);

            Console.Write("Give the second number!\n> ");
            string secondInput = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondInput);

            Console.Write("Give the third number!\n> ");
            string thirdInput = Console.ReadLine();
            int thirdNumber = Convert.ToInt32(thirdInput);

            int sum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine("The sum is "+ sum);
            Console.ReadKey();

    }
  }
}
