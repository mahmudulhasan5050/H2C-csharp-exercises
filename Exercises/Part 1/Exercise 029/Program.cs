using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("Give the first number!\n> ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give the second number!\n> ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The larger number is " + firstNumber +"!");
            }
            else if(firstNumber < secondNumber)
            {
                Console.WriteLine("The larger number is " + secondNumber +"!");            
            }
            else
            {
            Console.WriteLine("They are equal!");
            }
            Console.ReadKey();

    }
  }
}
