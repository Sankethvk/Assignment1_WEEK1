using System;
using System.Collections.Generic;
using System.Text;

namespace Week1_Assignment1
{
    class aircraft_maintenance
    {
        public void data_maintenance()
        {
            Console.WriteLine("enter the aircraft name whose details you want");
            Console.WriteLine("Indigo  Vistara  AirIndia  AirAsia  GoAir");
            string flight_name = Console.ReadLine();
            switch(flight_name)
            {
               case "Indigo":
                    Console.WriteLine("{0} aircraft is under maintenance for 1 week", flight_name);
                    Console.WriteLine("serviceman name prashant - Ph No 9876253781");
                    Console.WriteLine("parked at spotID - 39A");
                    break;
                case "Vistara":
                    Console.WriteLine("{0} aircraft is under maintenance for 2 days", flight_name);
                    Console.WriteLine("serviceman name ramesh - Ph No 9823567881");
                    Console.WriteLine("parked at spotID - 39B");
                    break;
                case "AirIndia":
                    Console.WriteLine("{0} aircraft is under maintenance for 2 days", flight_name);
                    Console.WriteLine("serviceman name prashant - 9214520981");
                    Console.WriteLine("parked at spotID - 39C");
                    break;
                case "AirAsia":
                    Console.WriteLine("{0} aircraft is under maintenance for 2 days", flight_name);
                    Console.WriteLine("serviceman name prashant - 9876253781");
                    Console.WriteLine("parked at spotID - 39D");
                    break;
                case "GoAir":
                    Console.WriteLine("{0} aircraft is under maintenance for 2 days", flight_name);
                    Console.WriteLine("serviceman name prashant - 9879904268");
                    Console.WriteLine("parked at spotID - 39E");
                    break;
                default:
                    Console.WriteLine("Flight does not exist");
                    break;
            }

        }
    }
}
