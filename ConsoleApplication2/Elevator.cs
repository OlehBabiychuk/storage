using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
 public class Elevator
    {
        public int ID;
        public int ElevCurF;
        public int EndElevF;
        public bool isMoving;
        public string Direction;

        public Elevator(int ID, int ElevCurF, int? EndElevF, bool isMoving, string Direction)
        {
            this.ID = ID;
            this.ElevCurF = ElevCurF;
            this.EndElevF = EndElevF.GetValueOrDefault();
            this.isMoving = isMoving;
            this.Direction = Direction;

        }
        public void Show()
        {
            Console.WriteLine("The Elevator{0} on {1} floor, coming to {2} floor", ID, ElevCurF, EndElevF);
        }
    }

}
