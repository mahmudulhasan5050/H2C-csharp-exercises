using System;

namespace exercise_23
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

            int add = firstNumber + secondNumber; 
            int deduct = firstNumber - secondNumber;
            int multiply = firstNumber * secondNumber;
            double divide = (double)firstNumber/secondNumber;

            Console.WriteLine(firstNumber+" + "+secondNumber+" = "+add);
            Console.WriteLine(firstNumber+" - "+secondNumber+" = "+deduct);
            Console.WriteLine(firstNumber+" * "+secondNumber+" = "+multiply);
            Console.WriteLine(firstNumber+" / "+secondNumber+" = "+divide);
            Console.ReadKey();

    }
  }
}
