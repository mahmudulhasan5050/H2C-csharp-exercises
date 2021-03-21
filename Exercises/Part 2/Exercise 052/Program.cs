using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintFromNumberToOne(9);
            Console.ReadKey();
    }

    // Write your method here:
            public static void PrintFromNumberToOne(int number) {
          
            for(int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            }
  }
}
