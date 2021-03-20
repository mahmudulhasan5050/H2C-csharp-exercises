using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0;
            int count = 0;
            double average = 0;
            int evenCount = 0;
            int oddCount = 0;

      Console.WriteLine("Give numbers:");

            while (true) {
                Console.Write("> ");
                int numbers = Convert.ToInt32(Console.ReadLine());

                if (numbers == -1)
                {
                    Console.WriteLine("Thx! Bye!");
                    break;
                }
                else
                {
                    if(numbers%2 == 0)
                    {
                        evenCount = evenCount + 1;
                    }
                    else
                    {
                        oddCount = oddCount + 1;
                    }
                sum = sum + numbers;
                count = count + 1;                  
                 continue;
                }
                 
            }
            average = sum/(double)count;
            Console.WriteLine("Sum: "+ sum);
            Console.WriteLine("Numbers: "+ count);
            Console.WriteLine("Average: "+ average);
            Console.WriteLine("Even: "+ evenCount);
            Console.WriteLine("Odd: "+ oddCount);
            Console.ReadKey();
    }
  }
}
