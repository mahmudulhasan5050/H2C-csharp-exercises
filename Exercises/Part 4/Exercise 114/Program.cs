using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if(input == "end")
                {
                    break;
                }
                else
                {
                    counter = counter + 1;
                }
            }

            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
