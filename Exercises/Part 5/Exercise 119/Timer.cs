using System;
namespace exercise_119
{
    public class Timer
    {
        private ClockHand hundredth;
        private ClockHand second;

        public Timer()
        {

            this.hundredth = new ClockHand(100);
            this.second = new ClockHand(60);
        }

        public void Advance()
        {
            this.hundredth.Advance();

            if (this.hundredth == 0)
            {
                this.second.Advance();
            }
        }

        public override string ToString()
        {
            return this.hundredth + ":" + this.second; ;
        }
    }
}