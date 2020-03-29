using System;
using System.Collections.Generic;
using System.Text;

namespace project_B
{
    public class Seats
    {
        public int Hall;
        public int SeatNumber;
        public int Row;

        public void chooseSeat()
        {
            Console.WriteLine("Choose your seat.");
            if (Hall == 1) ;
            {
                string s = "";
                for (int i = 0; i <= 150; i++)
                {
                    s += i + " ";
                    if ((i == 10)) ;
                    {
                        s += "\r\n";
                    }
                }
                Console.WriteLine(s);
            }

        }
    }
  
}