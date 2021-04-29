using System;

namespace exercise_123
{
    public class Counter
    {
        public int value { get; set; }

        public Counter()
        {
            this.value = 0;
        }
        public Counter(int startValue)
        {
            this.value = startValue;
        }

        public void Increase()
        {
            this.Increase(1);
        }
        public void Increase(int increaseBy)
        {
            if (this.value >= 0)
            {
               this.value += increaseBy;
            }
            else { Console.WriteLine("Value is less than 0."); };
        }
        public void Decrease()
        {
            this.Decrease(1);
        }
        public void Decrease(int decreaseBy)
        {
            if (this.value >= 0)
            {
                this.value -= decreaseBy;
            }
            else { Console.WriteLine("Value is less than 0."); }
        }

        public override string ToString()
        {
            return "The value has changed "+this.value;
        }
    }
}