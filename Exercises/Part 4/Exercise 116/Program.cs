using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Read the file data.txt and print the text from it as it is
      // You can use either File.ReadAllText or File.ReadAllLines

       // string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Exercise 116", "data.txt");
        string text = File.ReadAllText("data.txt");
            
        Console.WriteLine(text);
            

            Console.ReadKey();
      
    }
  }
}
