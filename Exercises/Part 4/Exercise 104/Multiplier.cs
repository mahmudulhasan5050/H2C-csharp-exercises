using System;

namespace exercise_104
{
    public class Multiplier
    {
        public int number { get; set; }
        public int result { get; set; }

        public Multiplier(int number)
        {
            this.number = number;
            this.result = 0;
        }

        public int Multiply(int number)
        {
            this.result = this.number * number;
            return this.result;
        }
    }
}