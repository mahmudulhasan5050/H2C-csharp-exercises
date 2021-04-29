using System;
using System.IO;
namespace exercise_120
{
  class Program
  {
    public static void Main(string[] args)
    {
            
      int edge = Convert.ToInt32(Console.ReadLine());

            Cube myCube = new Cube(edge);

            Console.WriteLine(myCube);
            Console.ReadKey();



      
    }
  }
}
