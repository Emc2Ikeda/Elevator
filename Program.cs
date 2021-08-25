using System;

namespace ElevatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // starting floor. Assume user starts from 1F
            int currentFloor = 1;
            // enter elevator
            Console.WriteLine("Select Floor\n1\n2\n3\n4\n5\n6\n7\n8\n9\n10");
            string floor = Console.ReadLine();
            Console.WriteLine("Floor: " + floor);
            // convert floor to int
            int changeFloor = Convert.ToInt32(floor);
            // move you up or down x number of floors
            currentFloor = changeFloor;
            Console.WriteLine(currentFloor);

            // leave elevator
            Console.WriteLine("Arrived at " + currentFloor + ".Goodbye");
        }
    }
}
