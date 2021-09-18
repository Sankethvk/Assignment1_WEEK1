using System;
using System.Collections.Generic;
using System.Text;

namespace Week1_Assignment1
{
    class bookTicket
    {
        Question3_luggage lg = new Question3_luggage();
        private string name, departure_location, destination, date, age,flight_class;
        int kg;

        public string Flight_class { get => flight_class; set => flight_class = value; }
        public string Name { get => name; set => flight_class = name; }

        public string Departure_location { get => departure_location; set => departure_location = value; }

        public string Date { get => date; set => date = value; }

        public string Age { get => age; set => age = value; }

        public string Destination { get => destination; set => destination = value; }



        public void passenger_data()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter age");
            age = Console.ReadLine();
            Console.WriteLine("enter departure location");
            departure_location = Console.ReadLine();
            Console.WriteLine("enter destination");
            destination = Console.ReadLine();
            Console.WriteLine("enter date in format - dd/mm/yyyy");
            date = Console.ReadLine();
            Console.WriteLine("enter class of your flight");
            flight_class = Console.ReadLine();
            Console.WriteLine("enter weight of luggage");
            kg = Convert.ToInt32(Console.ReadLine());
            
            lg.Luggage(flight_class, kg);
        }
        
    }
    class bookETicket : bookTicket
    {
        int num;
        
        
   
        public void ebookin()
        {
            
            Console.WriteLine("enter number of passengers");
            num = Convert.ToInt32(Console.ReadLine());
            string[,] lst = new string[num, 6];
            Console.WriteLine("enter the details of the passengers");
            for (int i = 0; i < num; i++)
            {
                
                passenger_data();
                lst[i, 0] = Name;
                lst[i, 1] = Age;
                lst[i, 2] = Departure_location;
                lst[i, 3] = Destination;
                lst[i, 4] = Date;
                lst[i, 5] = Flight_class;
               
                
            }
            Console.WriteLine("your ticket has been booked \n have a safe and happy journey :) ");
            Console.WriteLine("Please find your ticket below");
            printTickets(lst,num);
            
        }
        public void printTickets(string[,] l,int num)
        {
            for(int i=0;i<num;i++)
            {
                for(int j=0;j<6;j++)
                {
                    Console.Write(l[i,j] + "||");
                    
                    
                    
                }
                Console.WriteLine();
            }
            

        }
    }

}
