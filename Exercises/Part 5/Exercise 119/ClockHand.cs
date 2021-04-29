using System.IO;

namespace exercise_119
{
  public class ClockHand
  {
    public int value { get; set; }
    public int limit { get; set; }

    public ClockHand(int limit)
    {
      this.limit = limit;
      this.value = 0;
    }

    public void Advance()
    {
      this.value = this.value + 1;

      if (this.value >= this.limit)
      {
        this.value = 0;
      }
    }

    public override string ToString()
    {
      if (this.value < 10)
      {
        return "0" + this.value;
      }

      return "" + this.value;
    }
  }


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

            if (this.hundredth.value == 0)
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