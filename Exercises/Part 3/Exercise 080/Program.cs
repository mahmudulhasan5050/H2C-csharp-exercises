﻿using System;
using System.Collections.Generic;

namespace exercise_80
{
  class Program
  {
    public static void Main(string[] args)
    {
      int[] numbers = { 5, 1, 3, 4, 2 };
      int sum = SumOfNumbersInArray(numbers);
      Console.WriteLine(sum);

      Console.ReadKey();
    }

    public static int SumOfNumbersInArray(int[] numbers) {
      
            int numberSum = 0;
            foreach(int num in numbers)
            {
                numberSum = numberSum + num;
            }
     
            return numberSum;
    }

  }
}


