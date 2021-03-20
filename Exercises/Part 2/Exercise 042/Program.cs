using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.Write("> ");
            int firstInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("> ");
            int secondInput = Convert.ToInt32(Console.ReadLine());
           
            double squareRoot = Math.Sqrt(firstInput+secondInput);

            Console.WriteLine(squareRoot);
            Console.ReadKey();
    
    }
  }
}
