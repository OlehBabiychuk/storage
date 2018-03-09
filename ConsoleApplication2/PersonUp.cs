using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class PersonUp
    {
        public int UpSameFloor(Person Person, List<Elevator> ElList)
        {
            int PickEl = 0;
            foreach (var e in ElList)
            {
                if (e.Direction == "up")
                {
                    if (e.ElevCurF == Person.PerStFloor)

                    {
                        PickEl = e.ID;
                        break;
                    }
                }

            }
            return PickEl;
        }

        public int UpElev(Person Person, List<Elevator> ElList)
        {

            int MinEl = Person.PerStFloor;
            int PickEl = 0;
            foreach (var e in ElList)
            {
                if (e.Direction == "up")
                {
                    if (e.ElevCurF < Person.PerStFloor)
                    {
                        if (Person.PerStFloor - e.ElevCurF < MinEl)
                        {
                            MinEl = (Person.PerStFloor - e.ElevCurF);
                            PickEl = e.ID;
                        }


                    }
                }

            }
            return PickEl;
        }
        public int DownElev(Person Person, List<Elevator> ElList)
        {

            int MinEl = 0;
          
            foreach (var m in ElList)
            {
                if (m.Direction == "down")
                {
                    if (m.EndElevF >= Person.PerStFloor)
                    {
                        MinEl = m.ElevCurF;
                    }
                }
            }
            int pickEl = 0;
            foreach (var e in ElList)
            {
                if (e.Direction == "down")
                {
                    if (e.EndElevF >= Person.PerStFloor)
                    {
                        if (e.ElevCurF > Person.PerStFloor)
                        {
                            if (e.ElevCurF - Person.PerStFloor < MinEl)
                            {
                                MinEl = e.ElevCurF - Person.PerStFloor;
                                pickEl = e.ID;
                            }
                        }
                    }
                }
            }
            return pickEl;
        }

        public int StaticSameFloor(Person Person, List<Elevator> ElList)
        {
            int pickEl = 0;

            foreach (var e in ElList)
            {
                if (e.Direction == null)
                {
                    if (Person.PerStFloor == e.ElevCurF)
                    {
                        pickEl = e.ID;
                    }
                }
            }
            return pickEl;
        }
        public int StaticNotSameFloor(Person Person, List<Elevator> ElList)
        {
            int MinEl = 0;
            int pickEl = 0;
            foreach (var e in ElList)
            {
                if (!e.isMoving)
                {
                
                        MinEl = Math.Abs(Person.PerStFloor - e.ElevCurF);

                        break;
                   

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
