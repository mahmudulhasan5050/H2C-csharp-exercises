using System;

namespace exercise_99
{
  class Program
  {
    public static void Main(string[] args)
    {

      DecreasingCounter counter = new DecreasingCounter(11);
      counter.PrintValue();
      
      counter.Decrement();
      counter.PrintValue();
      
      counter.Decrement();
      counter.PrintValue();
    
      Console.WriteLine("After reset");
      counter.Reset();
      counter.PrintValue();

      Console.ReadKey();
    }
  }
}



