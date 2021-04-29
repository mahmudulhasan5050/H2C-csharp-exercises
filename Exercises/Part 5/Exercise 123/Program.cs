using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      int number = Convert.ToInt32(Console.ReadLine());
      Counter counter = new Counter(number);
      
            Console.WriteLine(counter);
            counter.Increase();
            Console.WriteLine(counter);
            counter.Increase(10);
            Console.WriteLine(counter);
            counter.Decrease(10);
            Console.WriteLine(counter);
            counter.Decrease();
            Console.WriteLine(counter);
            Console.ReadKey();
    }
  }
}
