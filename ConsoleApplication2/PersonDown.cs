using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class PersonDown
    {
        public int DownSameFloor(Person Person, List<Elevator> ElList)
        {
            int PickEl = 0;
            foreach (var e in ElList)
            {
                if (e.Direction == "down")
                {
                    if (e.ElevCurF == Person.PerStFloor)

                    { PickEl = e.ID; break; }
                }

            }
            return PickEl;
        }

        public int DownElev(Person Person, List<Elevator> ElList)
        {
            int MinEl=0;
           

            foreach (var e in ElList)
            {
                if(e.Direction== "down")
                if (e.ElevCurF < Person.PerStFloor)
                {
                    MinEl = e.ElevCurF;
                }
            }
            int PickEl = 0;
            foreach (var e in ElList)
            {
             
                if (e.Direction == "down")
                {
                    if (e.ElevCurF > Person.PerStFloor)
                    {
                        if (Person.PerStFloor - e.ElevCurF < MinEl)
                        {
                            MinEl = Math.Abs(Person.PerStFloor - e.ElevCurF);
                            PickEl = e.ID;
                        }
                    }
                }

            }

            return PickEl;
        }

        public int UpElev(Person Person, List<Elevator> ElList)
        {
            int MinEl = Person.PerStFloor;
            int PickEl = 0;

           // foreach (var e in ElList)
           /* {
                if (e.ElevCurF < Person.PerStFloor)
                {
                    MinEl = e.ElevCurF;
                }
            }*/
            foreach (var e in ElList)
            {
                if (e.Direction == "up")
                {
                    if (e.EndElevF <= Person.PerStFloor)
                    {
                        if (Person.PerStFloor - e.ElevCurF < MinEl)

                        {
                            MinEl = Person.PerStFloor - e.ElevCurF;
                            PickEl = e.ID;
                        }
                    }
                }


            }
            return PickEl;
        }

        public int StaticSameFloor(Person Person, List<Elevator> ElList)
        {
            int piclEl = 0;
            foreach (var e in ElList)
            {              
                if (!e.isMoving)
                    if (Person.PerStFloor == e.ElevCurF)
                    {
                        piclEl = e.ID;
                    }
            }
            return piclEl;
        }
    
        public int StaticNotSameFloor(Person Person, List<Elevator> ElList)
        {
            int MinEl = 0;
            int pickEl = 0;
            foreach (var e in ElList)
            {
                if (!e.isMoving)
                {
                    if (Person.PerStFloor > e.ElevCurF)
                    {
                        MinEl = Math.Abs(Person.PerStFloor - e.ElevCurF);

                        break;
                    }

                }
            }
            foreach (var e in ElList)
            {
                if (!e.isMoving)
                {
                    if (Math.Abs(Person.PerStFloor - e.ElevCurF) <= MinEl)
                    {

                        MinEl = Math.Abs(Person.PerStFloor - e.ElevCurF);
                        pickEl = e.ID;
                    }
                }
            }
            return pickEl;
        }
    }
}
