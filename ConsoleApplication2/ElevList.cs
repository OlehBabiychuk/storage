using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   public class ElevList
    {
        Person Person;
        PersonUp PerUp = new PersonUp();
        PersonDown PerDown = new PersonDown();
        List<Elevator> elev = new List<Elevator>();
        public void AddElev(Elevator elv)
        {
            elev.Add(elv);
        }
        public void ShowAll()
        {
            foreach (var e in elev)
                e.Show();
        }
        

        public void AddPerson(int floor, string direction)
        {
            Person=new Person(floor, direction);
        }
        public int PickElevator()
        {
            int PickEl = 0;
            switch (Person.PerDirection)
            {
                case "up":
                    PickEl = PerUp.UpSameFloor(Person, elev);
                    if(PickEl==0)
                    {
                        PickEl = PerUp.StaticSameFloor(Person, elev);
                        if(PickEl==0)
                        {
                            PickEl = PerUp.UpElev(Person, elev);

                            if(PickEl==0)
                            {
                                PickEl = PerUp.DownElev(Person, elev);

                                if(PickEl==0)
                                {
                                    PickEl = PerUp.StaticNotSameFloor(Person, elev);
                                    break;
                                }
                            }
                        }
                    }
                    
                    break;
                case "down":
                    PickEl = PerDown.DownSameFloor(Person, elev);
                    if (PickEl == 0)
                    {
                        PickEl = PerDown.StaticSameFloor(Person, elev);
                        if (PickEl == 0)
                        {
                            PickEl = PerDown.DownElev(Person, elev);

                            if (PickEl == 0)
                            {
                                PickEl = PerDown.UpElev(Person, elev);

                                if (PickEl == 0)
                                {
                                    PickEl = PerDown.StaticNotSameFloor(Person, elev);
                                }
                            }
                        }



                    }
                    break;

                    default:
                       System.Console.WriteLine($"An unexpected value ({Person.PerDirection})");
                       break;               
            }
            return PickEl;
        } 
    }
}
