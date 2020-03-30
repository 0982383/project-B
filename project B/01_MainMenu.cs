using System;
using System.Collections;
using System.Linq;
using System.Text;


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
            Console.WriteLine("2: Back");
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
                        StaffMenu();
                        break;
                    }
            }
        }
    // End Main Menu

    //Choose Movie
        private static void MovieList(int previousScreen)
        {
            
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Choose Movie:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1) Jumanji");
            Console.WriteLine("2) Harry Potter");
            Console.WriteLine("3) Ride Along 2");
            Console.WriteLine("4) Spencer Confidential");
            Console.WriteLine("5) Fast & Furious");
            Console.WriteLine("6) 6 Underground");
            Console.WriteLine("7) DeadPool 2");
            Console.WriteLine("8) Death at a Funeral");
            Console.WriteLine("9) Rush Hour 3");
            Console.WriteLine("10) The Dark Knight");
            Console.WriteLine("11) Back");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.Write("\r\nSelect Movie: ");

            string input;
            input = Console.ReadLine();
            Console.Clear();


            switch (input)
            {
                case "1":
                    {
                        Jumanji(previousScreen);
                        break;
                    }
                case "2":
                    {
                        HarryPotter(previousScreen);
                        break;
                    }
                case "3":
                    {
                        RideAlong2(previousScreen);
                        break;
                    }
                case "4":
                    {
                        SpencerConfidential(previousScreen);
                        break;
                    }
                case "5":
                    {
                        FastAndFurious(previousScreen);
                        break;
                    }
                case "6":
                    {
                        SixUnderground(previousScreen);
                        break;
                    }
                case "7":
                    {
                        DeadPool2(previousScreen);
                        break;
                    }
                case "8":
                    {
                        Funeral(previousScreen);
                        break;
                    }
                case "9":
                    {
                        RushHou3(previousScreen);
                        break;
                    }
                case "10":
                    {
                        TheDarkKnight(previousScreen);
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
            string[] seats = new string [hall];

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
                seats[z] = "" + (z+1);  // puts number in aray
                Console.Write(z+1 + " ");  // writes seatnumber on console
                if ((z+1) % 10 == 0)
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
    }
}

