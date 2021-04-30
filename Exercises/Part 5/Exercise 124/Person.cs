using System;

namespace exercise_124
{
    public class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string giveLastName()
        {
          return  this.name = this.name + " last";
        }

        public override string ToString()
        {
            return ""+ this.name;
        }
    }
}