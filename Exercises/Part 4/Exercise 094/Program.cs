﻿using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
            Account heikkisAccount = new Account("Heikki's account", 1000.0);
            Account personalAccount = new Account("Personal account", 0.0);

            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personalAccount);

            heikkisAccount.Withdrawal(100);
            personalAccount.Deposit(100);

            Console.WriteLine();
            Console.WriteLine("Updated info");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personalAccount);

            Console.ReadKey();
    }
  }
}



