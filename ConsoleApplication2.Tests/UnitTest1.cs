using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace ConsoleApplication2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingElevator()
        {

            //arrange
            
            ElevList elev = new ElevList();
            elev.AddPerson(5, "up");

            elev.AddElev(new Elevator(3, 10, 1, true, "down"));
            elev.AddElev(new Elevator(1, 8, 13, true, "up"));
            elev.AddElev(new Elevator(2, 4, null, false, null));

            int expected=2;
           
            //act
           int actual= elev.PickElevator();
            //assert
           Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingElevator2()
        {

            //arrange

            ElevList elev = new ElevList();
            elev.AddPerson(6, "down");
            elev.AddElev(new Elevator(1, 1, 6, true, "down"));
            elev.AddElev(new Elevator(2, 4, 13, true, "up"));
            elev.AddElev(new Elevator(3, 8, 2, true, "down"));

            int expected = 3;

            //act
            int actual = elev.PickElevator();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingElevator3()
        {

            //arrange

            ElevList elev = new ElevList();

            elev.AddPerson(9, "up");
            elev.AddElev(new Elevator(1, 6, 1, true, "down"));
            elev.AddElev(new Elevator(2, 13, 2, true, "down"));
            elev.AddElev(new Elevator(3, 6, null, false, null));

            int expected = 3;

            //act
            int actual = elev.PickElevator();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NewTestingElevator1()
        {

            //arrange 
            ElevList elev = new ElevList();
            elev.AddPerson(5, "down");
            elev.AddElev(new Elevator(1, 7, 9, true, "up"));
            elev.AddElev(new Elevator(2, 1, 6, true, "up"));
            elev.AddElev(new Elevator(3, 8, null, false, null));
            elev.AddElev(new Elevator(4, 9, 6, true, "down"));
            elev.AddElev(new Elevator(5, 9, 10, true, "up"));

            int expected = 4;

            //act
            int actual = elev.PickElevator();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewTestingElevator2()
        {
            //arrange 


            ElevList elev = new ElevList();

            elev.AddPerson(7, "up");
            elev.AddElev(new Elevator(1, 7, 9, true, "up"));
            elev.AddElev(new Elevator(2, 10, 20, true, "up"));
            elev.AddElev(new Elevator(4, 8, null, false, null));
            elev.AddElev(new Elevator(3, 1, 8, true, "up"));


            int expected = 1;

            //act
            int actual = elev.PickElevator();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewTestingElevator3()
        {
            //arrange 


            ElevList elev = new ElevList();
            elev.AddPerson(3, "up");


            elev.AddElev(new Elevator(1, 7, 9, true, "up"));
            elev.AddElev(new Elevator(2, 1, 10, true, "up"));
            elev.AddElev(new Elevator(3, 6, 8, true, "up"));

            int expected = 2;

            //act
            int actual = elev.PickElevator();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NewTestingElevator4() 
        {
            //arrange 


            ElevList elev = new ElevList();
            elev.AddPerson(10, "down");


            elev.AddElev(new Elevator(1, 8, 1, true, "down"));
            elev.AddElev(new Elevator(2, 7, 8, true, "up"));
            elev.AddElev(new Elevator(3, 10, 9, true, "down"));
            elev.AddElev(new Elevator(4, 8, null, false, null));
            elev.AddElev(new Elevator(5, 10, 8, true, "down"));

            int expected = 3;

            //act
            int actual = elev.PickElevator();

            //assert
            Assert.AreEqual(expected, actual);
        }



    }
}
