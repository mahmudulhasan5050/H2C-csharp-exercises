using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> names = new List<Item>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if(name == "")
                {
                    break;
                }
                else
                {
                    names.Add(new Item(name));
                }
            }
            
            foreach(Item nam in names)
            {
                Console.WriteLine(nam);
            }

            Console.ReadKey();
    }
  }
}




