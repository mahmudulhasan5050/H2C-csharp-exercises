using System;

namespace exercise_102
{
    public class Gauge
    {
        public int value { get; set;}

        public Gauge()
        {
            this.value = 0;
        }

        public void Increase()
        {
            if(this.value <= 5)
            {
                this.value = this.value + 1;
            }
        }

        public void Decrease()
        {
            if(this.value > 0)
            {
                this.value = this.value - 1;
            }
        }

        public bool Full()
        {
            if(this.value == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}