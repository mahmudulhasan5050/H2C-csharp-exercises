using System;
using System.IO;
namespace exercise_120
{
    public class Cube
    {
        public int edgeLength;

        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
        }

        public int Volume()
        {
            return this.edgeLength * this.edgeLength * this.edgeLength;
        }

        public override string ToString()
        {
            return "The length of the edge is " + this.edgeLength + " and the volume " + this.Volume();
        }
    }

}