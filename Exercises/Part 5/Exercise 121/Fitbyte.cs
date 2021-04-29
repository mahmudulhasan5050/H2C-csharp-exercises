using System;
using System.IO;

namespace exercise_121
{
    public class Fitbyte
    {
        public int age;
        public int restingHeartRate;

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }

        public double meximumHeartRate()
        {
            return 206.3 - (0.711 * this.age);
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            return (this.meximumHeartRate() - this.restingHeartRate) * percentageOfMaximum + this.restingHeartRate;
        }
    }
}