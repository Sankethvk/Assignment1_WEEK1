using System;
using System.Collections.Generic;
using System.Text;

namespace Week1_Assignment1
{
    class Question3_luggage
    {
        public void Luggage(string c,double kg)
        {
            if(c=="first")
            {
                if(kg <= 50)
                {
                    Console.WriteLine("it is under limit no extra cost to be paid");
                }
                else
                {
                    double q = kg - 50;
                    Console.WriteLine("it is above permitted limit ,please pay additional cost of ${0} ", 2 * q);
                }

            }
            if(c=="business")
            {
                if(kg<= 40)
                {
                    Console.WriteLine("it is under limit no extra cost to be paid");
                }
                else
                {
                    double q = kg - 40;
                    Console.WriteLine("it is above permitted limit ,please pay additional cost of ${0}", 2 * q);
                }
            }
            if(c=="economy")
            {
                if (kg <= 20)
                {
                    Console.WriteLine("it is under limit no extra cost to be paid");
                }
                else
                {
                    double q = kg - 20;
                    Console.WriteLine("it is above permitted limit ,please pay additional cost of ${0}", 2 * q);
                }
            }
            

        }
    }
}
