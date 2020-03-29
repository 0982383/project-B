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
                    static void seatScreen(int[] seats)
                    {

                        for (int z = 1; z < seats.Length; z++)
                        {
                            seats[z] = z;

                            Console.Write(seats[z] + " ");
                            if (z % 10 == 0)
                            {
                                Console.WriteLine("\n");
                            }


                        }


                        Console.WriteLine(seats);
                        Console.Write("Type a number from 1 to 150 to choose your seat: ");
                        string bookedSeats = Console.ReadLine();
                        Console.WriteLine("You have chosen seat: " + bookedSeats);
                        int numberBookedSeats = int.Parse(bookedSeats);
                        if (numberBookedSeats == seats[numberBookedSeats])
                        {
                            seats[numberBookedSeats] = 0;
                        }
                        Console.WriteLine(seats);


                    }
                    seatScreen(new int[151]);



                }

                if (Hall == 2)
                {
                    static void seatScreen(int[] seats)
                    {

                        for (int z = 1; z < seats.Length; z++)
                        {
                            seats[z] = z;

                            Console.Write(seats[z] + " ");
                            if (z % 10 == 0)
                            {
                                Console.WriteLine("\n");
                            }


                        }


                        Console.WriteLine(seats);
                        Console.Write("Type a number from 1 to 150 to choose your seat: ");
                        string bookedSeats = Console.ReadLine();
                        Console.WriteLine("You have chosen seat: " + bookedSeats);
                        int numberBookedSeats = int.Parse(bookedSeats);
                        if (numberBookedSeats == seats[numberBookedSeats])
                        {
                            seats[numberBookedSeats] = 0;
                        }
                        Console.WriteLine(seats);


                    }
                    seatScreen(new int[301]);
                }
                if (Hall == 3)
                {
                    static void seatScreen(int[] seats)
                    {

                        for (int z = 1; z < seats.Length; z++)
                        {
                            seats[z] = z;

                            Console.Write(seats[z] + " ");
                            if (z % 10 == 0)
                            {
                                Console.WriteLine("\n");
                            }


                        }


                        Console.WriteLine(seats);
                        Console.Write("Type a number from 1 to 150 to choose your seat: ");
                        string bookedSeats = Console.ReadLine();
                        Console.WriteLine("You have chosen seat: " + bookedSeats);
                        int numberBookedSeats = int.Parse(bookedSeats);
                        if (numberBookedSeats == seats[numberBookedSeats])
                        {
                            seats[numberBookedSeats] = 0;
                        }
                        Console.WriteLine(seats);


                    }
                    seatScreen(new int[501]);

                }




            }
        }

    }