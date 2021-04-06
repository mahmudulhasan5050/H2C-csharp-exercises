using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
            Account heikkisAccount = new Account("Heikki's account", 100.00);

            Console.WriteLine("Intial state");
            Console.WriteLine(heikkisAccount);

            heikkisAccount.Deposit(20.0);

            Console.WriteLine("End state");
            Console.WriteLine(heikkisAccount);

            Console.ReadKey();
    }
  }
}



