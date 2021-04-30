using System;
using System.IO;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
      Person person = new Person("jhon");
            person = null;
            person.giveLastName();
            Console.WriteLine(person);
            Console.ReadKey();
      
    }
  }
}
