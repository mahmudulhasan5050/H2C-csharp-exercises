namespace exercise_105
{
  public class Statistics
  {
    public int count { get; set; }
    public int sum { get; set; }

    public Statistics()
    {
        this.count = 0;
           
    }

    public void AddNumber(int number)
    {
      // write code here

      this.sum = this.sum + number;
      this.count = this.count + 1;
      
    }
  }
}