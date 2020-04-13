﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Project_B
{
    class MainMenu
    {
        static void Main(string[] args)
        {
            // Begin Program
            BeginMenu();
        }

        // Main Menu
        public static void BeginMenu()
        {
            string OPT;
            Console.WriteLine("Welcome to cinema application");
            Console.WriteLine("Please choose a option to continue");
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Staff");
            Console.Write("Input: ");

            OPT = Console.ReadLine().ToLower();
            Console.Clear();

            switch (OPT)
            {
                case "1":
                    {
                        CustomerMenu();
                        break;
                    }

                case "2":
                    {
                        StaffMenu();
                        break;
                    }

                case "3":
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }

        public static void CustomerMenu()
        {
            string OPT2;
            Console.WriteLine("Welcome customer, what would you like to do?");
            Console.WriteLine("Please choose a number to continue");
            Console.WriteLine("1. See available movies");
            Console.WriteLine("2. See offers");
            Console.WriteLine("3. About us");
            Console.Write("Input: ");

            OPT2 = Console.ReadLine();
            Console.Clear();

            switch (OPT2)
            {
                case "1":
                    {
                        MovieList(1);
                        break;
                    }
                case "2":
                    {
                        //Offers();
                        break;
                    }
                case "3":
                    {
                        //AboutUs();
                        break;
                    }
            }
        }

        public static void StaffMenu()
        {
            string OPT3;
            Console.WriteLine("Welcome, do you wish to continue as manager or employee?");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Employee");
            Console.Write("Input: ");

            OPT3 = Console.ReadLine().ToLower();
            Console.Clear();

            switch (OPT3)
            {
                case "1":
                case "manager":
                    {
                        Console.Clear();
                        Manager();
                        break;
                    }
                case "2":
                case "employee":
                    {
                        Console.Clear();
                        Employee();
                        break;
                    }
            }
        }

        public static void Manager()
        {

            string input;
            Console.WriteLine("Manager Menu");
            Console.WriteLine("Press 1: Choose a Movie");
            Console.WriteLine("Press 2: Back");
            Console.Write("Input: ");

            input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        MovieList(2);
                        break;
                    }
                case "2":
                    {
                        StaffMenu();
                        break;
                    }
            }

        }

        public static void Employee()
        {

            string input;
            Console.WriteLine("Employee Menu");
            Console.WriteLine("1: Choose a Movie");
            Console.WriteLine("2: Add or remove a Movie");
            Console.WriteLine("3: Back");
            Console.Write("Input: ");


            input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        MovieList(3);
                        break;
                    }
                case "2":
                    {
                        AddMovie();
                        break;
                    }
                case "3":
                    {
                        StaffMenu();
                        break;
                    }
            }
        }

        public static void AddMovie()
        {
            // UNDER PROGRESS @Patryk
            var JsonString = File.ReadAllText("List.json");
            var JObject1 = JArray.Parse(JsonString);
            Console.WriteLine(JObject1.SelectToken("Title").Value<string>());
            var myList = JObject1.SelectTokens("$.MyListOfMovies").Values<string>().ToList();

            Console.WriteLine("-------------------------------");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i].ToString());
            }
            Console.WriteLine("-------------------------------");
            

            string input;
            Console.WriteLine("\n\n");
            Console.WriteLine("1: Addmovie");
            Console.WriteLine("2: Back");
            Console.Write("Input: ");


            input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        string AddMovieInput = Console.ReadLine();
                        int Counter = myList.Count + 1;
                        string Combine = Counter + ") " + AddMovieInput;

                        var initialJSON = File.ReadAllText(@"List.Json");


                        JArray MovieArray = JArray.Parse(initialJSON);
                        var MovieAdder = new JObject();
                        MovieAdder["MyListOfMovies"] = Combine;
                        MovieArray.Add(MovieAdder);
                       

                        JsonConvert.SerializeObject(MovieArray, Formatting.Indented);
                        //File.AppendAllText(@"List.Json", Combine.ToString());
                        AddMovie();
                        break;
                    }
                case "2":
                    {
                        StaffMenu();
                        break;
                    }
            }
        }
        // End Main Menu
        //Choose Movie
        private static void MovieList(int previousScreen)
        {
            var JsonString = File.ReadAllText("List.json");
            var JObject1 = JObject.Parse(JsonString);
            Console.WriteLine(JObject1.SelectToken("Title").Value<string>());
            var myList = JObject1.SelectTokens("$.MyListOfMovies").Values<string>().ToList();
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i].ToString());
            }
            Console.WriteLine("11) Exit");
            Console.WriteLine("-------------------------------");
            Console.Write("\r\nSelect Movie: ");

            string input;
            input = Console.ReadLine();
            Console.Clear();


            switch (input)
            {
                case "1":
                    {
                        venuedate(1);
                        break;
                    }
                case "2":
                    {
                        venuedate(2);
                        break;
                    }
                case "3":
                    {
                        venuedate(3);
                        break;
                    }
                case "4":
                    {
                        venuedate(4);
                        break;
                    }
                case "5":
                    {
                        venuedate(5);
                        break;
                    }
                case "6":
                    {
                        venuedate(6);
                        break;
                    }
                case "7":
                    {
                        venuedate(7);
                        break;
                    }
                case "8":
                    {
                        venuedate(8);
                        break;
                    }
                case "9":
                    {
                        venuedate(9);
                        break;
                    }
                case "10":
                    {
                        venuedate(10);
                        break;
                    }
                case "11":
                    {
                        if (previousScreen == 1)
                        {
                            CustomerMenu();
                            break;
                        }
                        if (previousScreen == 2)
                        {
                            Manager();
                            break;
                        }
                        if (previousScreen == 3)
                        {
                            Employee();
                            break;
                        }
                        break;
                    }
            }
        }
        // all the methodes for each movie 
        private static void Jumanji(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Movie: Jumanji");
            Console.WriteLine("Duration: 123 minutes");
            Console.WriteLine("Date: 31-3-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press Enter to return to MovieList");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(1, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }
        }

        private static void HarryPotter(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Movie: Harry Potter");
            Console.WriteLine("Duration: 159 minutes");
            Console.WriteLine("Date: 31-3-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press Enter to return to MovieList");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(1, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }
        }

        private static void RideAlong2(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Movie: Ride Along 2");
            Console.WriteLine("Duration: 102 minutes");
            Console.WriteLine("Date: 31-3-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press Enter to return to MovieList");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(1, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }

        }

        private static void SpencerConfidential(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Spencer Confidential");
            Console.WriteLine("Duration: 111 minutes");
            Console.WriteLine("Date: 1-4-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press Enter to return to MovieList");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(2, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }

        }

        private static void FastAndFurious(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Fast & Furious");
            Console.WriteLine("Duration: 135 minutes");
            Console.WriteLine("Date: 1-4-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press Enter to return to MovieList");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(2, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }

        }

        private static void SixUnderground(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("6 underground");
            Console.WriteLine("Duration: 128 minutes");
            Console.WriteLine("Date: 1-4-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press Enter to return to MovieList");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(3, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }

        }

        private static void DeadPool2(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("DeadPool 2");
            Console.WriteLine("Duration: 134 minutes");
            Console.WriteLine("Date: 2-4-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press Enter to return to MovieList");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(3, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }

        }

        private static void Funeral(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Dead at a Funeral");
            Console.WriteLine("Duration: 81 minutes");
            Console.WriteLine("Date: 2-4-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press Enter to return to MovieList");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(3, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }

        }

        private static void RushHou3(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Rush Hour 3");
            Console.WriteLine("Duration: 81 minutes");
            Console.WriteLine("Date: 3-4-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press Enter to return to MovieList");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(3, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }

        }

        private static void TheDarkKnight(int previousScreen)
        {
            Console.Clear();
            Console.WriteLine("The Dark Knight");

            Console.WriteLine("Duration: 152 minutes");
            Console.WriteLine("Date: 3-4-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("Press Enter to return to MovieList");

            Console.WriteLine("1. Order Ticket");
            Console.WriteLine("2. Back to Movies");
            string input;
            input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        ChooseSeat(3, "Harry Potter", previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "2":
                    {
                        MovieList(previousScreen);
                        break;
                    }

            }

        }
        //End Choose Movie

        //Choose Seat
        public static void ChooseSeat(int hall, string movie, int previousScreen, string selectedSeats, string[] selectedSeatsArray, string error, int max)
        {
            // Choose Seat Console Text
            string input;
            Console.WriteLine("\n       Selected Movie: " + movie);
            Console.WriteLine("\n         Seats ");

            // Show all Seats
            string showSeats = "    ";
            string[] seats = new string[hall];

            //Different Halls
            if (hall == 1)
            {
                seats = new string[150];
            }
            if (hall == 2)
            {
                seats = new string[300];
            }
            if (hall == 3)
            {
                seats = new string[500];
            }
            // End Different Hall

            for (int z = 0; z < seats.Length; z++)
            {
                seats[z] = "" + (z + 1);  // puts number in aray
                Console.Write(z + 1 + " ");  // writes seatnumber on console
                if ((z + 1) % 10 == 0)
                {
                    Console.WriteLine("\n"); // every 10 seats new line
                }
            }
            // End Show all Seats

            // Colored Selected Seats
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     " + error + "\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("     Currently selected seats:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    " + selectedSeats);
            Console.ForegroundColor = ConsoleColor.Gray;
            // End Colored Selected Seats

            Console.WriteLine("\n\n     Press 1: Choose Seat");
            Console.WriteLine("     Press 2: Reset");
            Console.WriteLine("     Press 3: Pay");
            Console.WriteLine("     Press 4: Back");
            Console.Write("\n       Input: ");

            // User Input
            input = Console.ReadLine();

            // End Choose Seat Console Text

            //  User Input Outcome
            switch (input)
            {
                case "1":
                    {
                        //User Input
                        string seatNumber;
                        int seatNumberINT;
                        Console.Write("\n\n     Choose Seat: ");
                        seatNumber = Console.ReadLine();
                        seatNumberINT = Convert.ToInt32(seatNumber);
                        //End User Input

                        // Checker
                        // Check if value exists
                        if (selectedSeatsArray.Contains("" + seatNumber))
                        {
                            error = "Seat already selected.";
                            Console.Clear();
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, error, max);
                            break;
                        }
                        // Check if max amount of seats does not exceed 5
                        else if (max <= 0)
                        {
                            error = "Max amount of seats selected";
                            Console.Clear();
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, error, max);
                            break;
                        }
                        // Check if seat exist
                        else if (seatNumberINT > seats.Length)
                        {
                            error = "Error, seat does not exist.";
                            Console.Clear();
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, error, max);
                            break;
                        }
                        else
                        {
                            selectedSeatsArray[max - 1] = "" + seatNumber;
                            selectedSeats += seatNumber + " ";
                            Console.Clear();
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, null, max - 1);
                            break;
                        }
                        // End Checker
                    }
                case "2":
                    {
                        Console.Clear();
                        ChooseSeat(hall, movie, previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for purchasing the tickets");
                        Console.Write("Press anything to go back");
                        Console.ReadLine();
                        Console.Clear();
                        if (previousScreen == 1)
                        {
                            CustomerMenu();
                            break;
                        }
                        if (previousScreen == 2)
                        {
                            Manager();
                            break;
                        }
                        if (previousScreen == 3)
                        {
                            Employee();
                        }
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        MovieList(previousScreen);
                        break;
                    }
            }
            // End User Input Oucome
        }
        //End Choose Seat
        public static void venuedate(int MViD)
        {
            Tuple<int, string>[] VenueMVlist = new Tuple<int, string>[10];
            string[] MVList = new string[10] { "Jumanji", "Harry Potter", "Ride Along 2", "Spencer Confidential", "Fast & Furious", "6 Underground", "Deadpool 2", "Death at a Funeral", "Rush hour 3", "The Dark Knight" };
            for (int i = 0; i < 10; i++)
            {
                if (i < 3)
                {
                    VenueMVlist[i] = Tuple.Create(1, MVList[i]);
                }
                else if(i < 6)
                {
                    VenueMVlist[i] = Tuple.Create(2, MVList[i]);
                }
                else
                {
                    VenueMVlist[i] = Tuple.Create(3, MVList[i]);
                }
               
            }
            string[] mvTimes = new string[5] { "Wednesday: 11:30 - 16:00 - 19:00 ", "Thursday: 11:30 - 16:00 - 19:00", "Tuesday:  11:30 - 16:00 - 19:00", "Monday: 11:30 - 16:00 - 19:00", "Friday: 11:30 - 16:00 - 19:00"};
            Tuple<string, string>[] VnDate1 = new Tuple<string, string>[5];
            Tuple<string, string>[] VnDate2 = new Tuple<string, string>[5];
            Tuple<string, string>[] VnDate3 = new Tuple<string, string>[5];
            for (int k = 0; k < 5; k++)
            {
                VnDate1[k] = Tuple.Create("Venue 1", mvTimes[k]);
                VnDate2[k] = Tuple.Create("Venue 2", mvTimes[k]);
                VnDate3[k] = Tuple.Create("Venue 3", mvTimes[k]);
            }
            string TL = "-------------------------------";
            string DVe = "Venue's and Time:";
            string plw = "Please write down the venue number and time in the following format to continue:";
            string frmat = "Venue#/##:##";
            Console.Clear();
            if (MViD == 1)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[0]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate1[0].Item1 + ": " + VnDate1[0].Item2);
                Console.WriteLine(VnDate3[4].Item1 + ": " + VnDate3[4].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();

            }
            else if(MViD == 2)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[1]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate1[1].Item1 + ": " + VnDate1[1].Item2);
                Console.WriteLine(VnDate2[4].Item1 + ": " + VnDate2[4].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();
            }
            else if(MViD == 3)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[2]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate2[0].Item1 + ": " + VnDate2[0].Item2);
                Console.WriteLine(VnDate3[1].Item1 + ": " + VnDate3[1].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();
            }
            else if(MViD == 4)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[3]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate1[2].Item1 + ": " + VnDate1[2].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();
            }
            else if (MViD == 5)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[4]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate2[3].Item1 + ": " + VnDate2[3].Item2);
                Console.WriteLine(VnDate3[0].Item1 + ": " + VnDate3[0].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();
            }
            else if (MViD == 6)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[5]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate1[4].Item1 + ": " + VnDate1[4].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();
            }
            else if (MViD == 7)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[6]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate2[2].Item1 + ": " + VnDate2[2].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();
            }
            else if(MViD == 8)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[7]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate1[3].Item1 + ": " + VnDate1[3].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();
            }
            else if(MViD == 9)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[8]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate2[1].Item1 + ": " + VnDate2[1].Item2);
                Console.WriteLine(VnDate3[3].Item1 + ": " + VnDate3[3].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();
            }
            else if(MViD == 10)
            {
                string Choice;
                Console.WriteLine(TL);
                Console.WriteLine("Selected movie:" + MVList[9]);
                Console.WriteLine(TL);
                Console.WriteLine(DVe);
                Console.WriteLine(VnDate3[2].Item1 + ": " + VnDate3[2].Item2);
                Console.WriteLine(TL);
                Console.WriteLine(plw);
                Console.WriteLine(frmat);
                Console.WriteLine(TL);
                Console.Write("Input:");
                Choice = Console.ReadLine().ToLower();
            }
        }
        public static void Payment()
        {


            Console.WriteLine("                                                -Choose your payment method-\n\n");
            Console.WriteLine("                                             Type in the number of your paymentmethod\n");


            string[] paymentMethods = new string[6] { "1) Paypal\n", "2) IDeal\n", "3) Creditcard\n", "4) Bitcoin\n", "5) Apple Pay\n", "6) Google Pay\n" };


            Console.WriteLine(paymentMethods[0]);
            Console.WriteLine(paymentMethods[1]);
            Console.WriteLine(paymentMethods[2]);
            Console.WriteLine(paymentMethods[3]);
            Console.WriteLine(paymentMethods[4]);
            Console.WriteLine(paymentMethods[5]);


            string num = Console.ReadLine();

            int num2 = Int32.Parse(num);

            if (num2 == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You have chosen paymentmehod  " + paymentMethods[0]);
                Console.WriteLine("press Enter to continue to the payment page");
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine(paymentMethods[0] + "\n");
                    Console.WriteLine("Press the spacebar button to complete the transaction ");
                    ConsoleKeyInfo keyInfo1;
                    keyInfo1 = Console.ReadKey();
                    if (keyInfo1.Key == ConsoleKey.Spacebar)
                    {
                        Console.WriteLine("Transaction completed. \n Thank you for you payment.");
                        Console.Beep();
                    }





                }
                else
                {
                    Console.WriteLine("you did not type the enter button :/");
                }
            }

            if (num2 == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You have chosen paymentmehod  " + paymentMethods[1]);
                Console.WriteLine("press Enter to continue to the payment page");
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine(paymentMethods[1] + "\n");
                    Console.WriteLine("Press the spacebar button to complete the transaction ");
                    ConsoleKeyInfo keyInfo1;
                    keyInfo1 = Console.ReadKey();
                    if (keyInfo1.Key == ConsoleKey.Spacebar)
                    {
                        Console.WriteLine("Transaction completed. \n Thank you for you payment.");
                        Console.Beep();
                    }
                    else
                    {
                        Console.WriteLine("you did not type the space bar :/");
                    }





                }
                else
                {
                    Console.WriteLine("you did not type the enter button :/");
                }
            }

            if (num2 == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You have chosen paymentmehod  " + paymentMethods[2]);
                Console.WriteLine("press Enter to continue to the payment page");
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine(paymentMethods[2] + "\n");
                    Console.WriteLine("Press the spacebar button to complete the transaction ");
                    ConsoleKeyInfo keyInfo1;
                    keyInfo1 = Console.ReadKey();
                    if (keyInfo1.Key == ConsoleKey.Spacebar)
                    {
                        Console.WriteLine("Transaction completed. \n Thank you for you payment.");
                        Console.Beep();
                    }
                    else
                    {
                        Console.WriteLine("you did not type the space bar :/");
                    }




                }
                else
                {
                    Console.WriteLine("you did not type the enter button :/");
                }
            }

            if (num2 == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You have chosen paymentmehod  " + paymentMethods[3]);
                Console.WriteLine("press Enter to continue to the payment page");
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine(paymentMethods[3] + "\n");
                    Console.WriteLine("Press the spacebar button to complete the transaction ");
                    ConsoleKeyInfo keyInfo1;
                    keyInfo1 = Console.ReadKey();
                    if (keyInfo1.Key == ConsoleKey.Spacebar)
                    {
                        Console.WriteLine("Transaction completed. \n Thank you for you payment.");
                        Console.Beep();
                    }
                    else
                    {
                        Console.WriteLine("you did not type the space bar :/");
                    }




                }
                else
                {
                    Console.WriteLine("you did not type the enter button :/");
                }
            }

            if (num2 == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You have chosen paymentmehod  " + paymentMethods[4]);
                Console.WriteLine("press Enter to continue to the payment page");
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine(paymentMethods[4] + "\n");
                    Console.WriteLine("Press the spacebar button to complete the transaction ");
                    ConsoleKeyInfo keyInfo1;
                    keyInfo1 = Console.ReadKey();
                    if (keyInfo1.Key == ConsoleKey.Spacebar)
                    {
                        Console.WriteLine("Transaction completed. \n Thank you for you payment.");
                        Console.Beep();
                    }
                    else
                    {
                        Console.WriteLine("you did not type the space bar :/");
                    }




                }
                else
                {
                    Console.WriteLine("you did not type the enter button :/");
                }
            }

            if (num2 == 6)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You have chosen paymentmehod  " + paymentMethods[5]);
                Console.WriteLine("press Enter to continue to the payment page");
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine(paymentMethods[5] + "\n");
                    Console.WriteLine("Press the spacebar button to complete the transaction ");
                    ConsoleKeyInfo keyInfo1;
                    keyInfo1 = Console.ReadKey();
                    if (keyInfo1.Key == ConsoleKey.Spacebar)
                    {
                        Console.WriteLine("Transaction completed. \n Thank you for you payment.");
                        Console.Beep();
                    }
                    else
                    {
                        Console.WriteLine("you did not type the space bar :/");
                    }




                }
                else
                {
                    Console.WriteLine("you did not type the enter button :/");
                }
            }






        }
    }

}

