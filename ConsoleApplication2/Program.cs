using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            ElevList elev = new ElevList();

            elev.AddPerson(6, "down");
            elev.AddElev(new Elevator(1, 1, 6, true, "down"));
            elev.AddElev(new Elevator(2, 4, 13, true, "up"));
            elev.AddElev(new Elevator(3, 8, 2, true, "down"));


            elev.PickElevator();
            
            elev.ShowAll();

            Console.WriteLine("Elevator {0} will be first", elev.PickElevator());
            Console.ReadKey();
        
      
            
        }
    }
}
