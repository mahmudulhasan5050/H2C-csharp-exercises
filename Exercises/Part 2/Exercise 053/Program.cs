using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
            Division(7,3);
            Console.ReadKey();

    }

    // Write your method here:
    public static void Division(int numerator, int denominator)
        {
            double result = numerator/(double)denominator;
            Console.WriteLine(result);
        }
  }
}
