using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   public class Person
    {
        public int PerStFloor;   
        public string PerDirection;

        public Person(int PerStFloor, string PerDirection)
        {
            this.PerStFloor = PerStFloor;
            this.PerDirection = PerDirection;
        }
    }
}
