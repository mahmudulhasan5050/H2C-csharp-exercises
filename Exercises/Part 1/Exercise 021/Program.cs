using System;

namespace exercise_21
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

            double average = (firstNumber+secondNumber)/2.0;

            Console.WriteLine("The average is " + average);
            Console.ReadKey();

    }
  }
}
