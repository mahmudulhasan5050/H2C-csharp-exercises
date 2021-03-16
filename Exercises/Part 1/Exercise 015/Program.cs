using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give a String:");
            Console.Write("> ");
            string stringValue = Console.ReadLine();

            Console.WriteLine("Give an integer:");
            Console.Write("> ");
            string stringIntValue = Console.ReadLine();
            int intValue = Convert.ToInt32(stringIntValue);

            Console.WriteLine("Give a double:");
            Console.Write("> ");
            string stringDoubleValue = Console.ReadLine();
            double doubleValue = Convert.ToDouble(stringDoubleValue);

            Console.WriteLine("Give a boolean:");
            Console.Write("> ");
            string stringBoolValue = Console.ReadLine();
            bool boolValue = System.Convert.ToBoolean(stringBoolValue);

            Console.WriteLine("Your string: "+ stringValue);
            Console.WriteLine("Your integer: "+ intValue);
            Console.WriteLine("Your double: "+ doubleValue);
            Console.WriteLine("Your boolean: "+ boolValue);

            Console.ReadKey();

    }
  }
}
