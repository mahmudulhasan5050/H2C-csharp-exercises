using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
            Account accountHasan = new Account("Hasan", 100.00);

            Console.WriteLine("Intial state");
            Console.WriteLine(accountHasan);

            accountHasan.Deposit(20.0);

            Console.WriteLine("End state");
            Console.WriteLine(accountHasan);

            Console.ReadKey();
    }
  }
}



