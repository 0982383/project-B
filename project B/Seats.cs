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
            if (Hall == 1)
            {
                static void seatScreen(string[] seats)
                {
                    for (int z = 1; z < seats.Length; z++)
                    {
                        seats[z] = "" + z;  // puts number in aray
                        Console.Write(seats[z] + " ");  // writes seatnumber on console
                        if (z % 10 == 0)
                        {
                            Console.WriteLine("\n"); // every 10 seats new line
                        }
                    }
                    Console.Write("Type a number from 1 to 150 to choose your seat: ");
                    string bookedSeats = Console.ReadLine();    // bookedSeats gives chosen seatnumber
                    int numberBookedSeats = int.Parse(bookedSeats); // convert (string bookedSeats) to (int numberBookedSeats)
                    Console.WriteLine("You have chosen seat: " + bookedSeats);
                    string c = seats[numberBookedSeats];    // assign string from array to string c
                    int d = int.Parse(c);   // convert string c to int d      
                    if (numberBookedSeats == d)
                    {
                        seats[d] = "*"; // replaces seat in array with *
                    }
                }
                seatScreen(new string[151]);
            }

            if (Hall == 2)
            {
                static void seatScreen(string[] seats)
                {
                    for (int z = 1; z < seats.Length; z++)
                    {
                        seats[z] = "" + z;  // puts number in aray
                        Console.Write(seats[z] + " ");  // writes seatnumber on console
                        if (z % 10 == 0)
                        {
                            Console.WriteLine("\n"); // every 10 seats new line
                        }
                    }
                    Console.Write("Type a number from 1 to 150 to choose your seat: ");
                    string bookedSeats = Console.ReadLine();    // bookedSeats gives chosen seatnumber
                    int numberBookedSeats = int.Parse(bookedSeats); // convert (string bookedSeats) to (int numberBookedSeats)
                    Console.WriteLine("You have chosen seat: " + bookedSeats);
                    string c = seats[numberBookedSeats];    // assign string from array to string c
                    int d = int.Parse(c);   // convert string c to int d      
                    if (numberBookedSeats == d)
                    {
                        seats[d] = "*"; // replaces seat in array with *
                    }
                }
                seatScreen(new string[301]);
            }

            if (Hall == 3)
            {
                static void seatScreen(string[] seats)
                {
                    for (int z = 1; z < seats.Length; z++)
                    {
                        seats[z] = "" + z;  // puts number in aray
                        Console.Write(seats[z] + " ");  // writes seatnumber on console
                        if (z % 10 == 0)
                        {
                            Console.WriteLine("\n"); // every 10 seats new line
                        }
                    }
                    Console.Write("Type a number from 1 to 150 to choose your seat: ");
                    string bookedSeats = Console.ReadLine();    // bookedSeats gives chosen seatnumber
                    int numberBookedSeats = int.Parse(bookedSeats); // convert (string bookedSeats) to (int numberBookedSeats)
                    Console.WriteLine("You have chosen seat: " + bookedSeats);
                    string c = seats[numberBookedSeats];    // assign string from array to string c
                    int d = int.Parse(c);   // convert string c to int d      
                    if (numberBookedSeats == d)
                    {
                        seats[d] = "*"; // replaces seat in array with *
                    }
                }
                seatScreen(new string[501]);
            }
        }
    }

}