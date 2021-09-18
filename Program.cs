using System;

namespace Week1_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question3 l = new Question3();
            //Console.WriteLine("enter class of your flight");
            //Console.WriteLine("enter economy for Economy class , business for Business class,first for First class");
            //string c = Console.ReadLine();
            //Console.WriteLine("enter weight of your luggage");
            //double kg = Convert.ToDouble(Console.ReadLine());
            //l.Luggage(c, kg);

            bookETicket etic = new bookETicket();
            etic.ebookin();
            Console.ReadLine();


            //aircraft_maintenance d = new aircraft_maintenance();
            //d.data_maintenance();


        }
    }
}
