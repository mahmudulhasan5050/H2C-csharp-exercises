using System;
using System.Collections.Generic;

namespace exercise_81
{
  class Program
  {
    public static void Main(string[] args)
    {
      int[] array = {5, 1, 3, 4, 2};

      // You can test your method here
      PrintNeatly(array);

            Console.ReadKey();
    }

    public static void PrintNeatly(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
            {
                if( i != array.Length - 1)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
    }
  }
}

