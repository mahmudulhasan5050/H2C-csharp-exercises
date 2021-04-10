using System;
using System.IO;

namespace exercise_117
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Ask the user for the file name and print the content of the file

          Console.Write("Which file should have its contents printed?\n> ");
          string fileName = Console.ReadLine();


      //  string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Exercise 117", fileName);
        string text = File.ReadAllText(fileName);
      
            Console.WriteLine(text);
            Console.ReadKey();
    }
  }
}
