using Newtonsoft.Json.Linq;
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
            SeatOptions.ResetSeats();
            PaymentSettings.ResetRevenue();
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
                        LoginScreen();
                        break;
                    }

                case "3":
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
        public static void LoginScreen()
        {
            Console.WriteLine("Hello , Enter you're username");
            Console.Write("username : ");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Now enter you password");
            Console.Write("password : ");
            string inputpassWord = Console.ReadLine();
            var JObject1 = JObject.Parse(File.ReadAllText(@"Supertest.json"));
            var account1 = JObject1.SelectToken("$.Tom").Value<string>();
            var account2 = JObject1.SelectToken("$.Feuzi").Value<string>();
            var account3 = JObject1.SelectToken("$.Jordi").Value<string>();
            var account4 = JObject1.SelectToken("$.Ismail").Value<string>();
            var account5 = JObject1.SelectToken("$.Patryck").Value<string>();
            if (inputpassWord == account1)
            {

                Console.Clear();
                Console.WriteLine("You have logged in.");
                CustomerMenu();
            }
            else if (inputpassWord == account2)
            {
                Console.Clear();
                Console.WriteLine("You have logged in.");
                CustomerMenu();
            }
            else if (inputpassWord == account3)
            {
                Console.Clear();
                Console.WriteLine("You have logged in.");
                CustomerMenu();
            }
            else if (inputpassWord == account4)
            {
                Console.Clear();
                Console.WriteLine("You have logged in.");
                StaffMenu();
            }
            else if (inputpassWord == account5)
            {
                Console.Clear();
                Console.WriteLine("You have logged in.");
                StaffMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have enterd wrong username/password. ");
                LoginScreen();

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
                        MovieOptions.MovieType();
                        break;
                    }
                case "2":
                    {
                        PaymentSettings.Offers();
                        break;
                    }
                case "3":
                    {
                        AboutUs();
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
            Console.WriteLine("Press 2: Show Daily Revenue");
            Console.WriteLine("Press 3: Back");
            Console.Write("Input: ");

            input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        MovieOptions.MovieType();
                        break;
                    }
                case "2":
                    {
                        PaymentSettings.ShowDailyRevenue(1);
                        break;
                    }
                case "3":
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
            Console.WriteLine("3: Show Daily Revenue");
            Console.WriteLine("4: Back");
            Console.Write("Input: ");


            input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        MovieOptions.MovieType();
                        break;
                    }
                case "2":
                    {
                        MovieOptions.AddMovie();
                        break;
                    }
                case "3":
                    {
                        PaymentSettings.ShowDailyRevenue(2);
                        break;
                    }
                case "4":
                    {
                        StaffMenu();
                        break;
                    }
            }
        }

        public static void AboutUs()
        {
            string input;
            Console.WriteLine("About Us\r\n");
            Console.WriteLine("CinemaWorld has 3 venues with a capacity of 150, 300 and 500 seats respectively.\r\n" +
                              "The team consist of the owner, Jake Darcy, the ticket office clerk, Art Brown, and Sally Buns.\r\n" +
                              "Jake is a film aficionado pur sang. He watches all movies and knows most actors and their histories by heart.\r\n" +
                              "He writes reviews of films in several magazines.This cinema is a dream come true for him, and the first in a great chain of cinemas to be. \r\n" +
                              "Art welcomes the customers and checks their tickets or reservations.\r\n" +
                              "He needs to be the face of the cinema experience.\r\n" +
                              "Sally Buns runs the theaters café and bar on a franchise basis.\r\n");
            Console.WriteLine("Press 1: Back");
            Console.Write("Input: ");

            input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        CustomerMenu();
                        break;
                    }
            }
        }
    }
    class MovieOptions {
        public static void AddMovie()
        {
            // json file should be updated @issie
            var JsonString = File.ReadAllText(@"List.json");
            var JObject1 = JObject.Parse(JsonString);
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
            Console.WriteLine("1: Add movie");
            Console.WriteLine("2: Remove movie");
            Console.WriteLine("3: Back");
            Console.Write("Input: ");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    {
                        //Getting movie name
                        Console.Write("Name of the movie:");
                        string AddMovieInput = Console.ReadLine();
                        int Counter = myList.Count + 1;
                        string Combine = Counter + ") " + AddMovieInput;

                        //Opening JSON file that needs to be modified
                        var initialJSON = File.ReadAllText(@"List.json");
                        dynamic jsonArray = JsonConvert.DeserializeObject(initialJSON);

                        //Adding the movie
                        jsonArray["MyListOfMovies"].Add(Combine);

                        //Saving and Closing JSON File
                        string output = JsonConvert.SerializeObject(jsonArray, Formatting.Indented);
                        File.WriteAllText(@"List.json", output);
                        //Saving and Closing JSON File

                        Console.Clear();
                        AddMovie();
                        break;
                    }
                case "2":
                    {
                        Console.Write("Choose the movie that you want to remove");
                        int removeMovie = Convert.ToInt32(Console.ReadLine());

                        //Opening JSON file that needs to be modified
                        var initialJSON = File.ReadAllText(@"List.json");
                        dynamic jsonArray = JsonConvert.DeserializeObject(initialJSON);

                        //Removing the movies
                        jsonArray["MyListOfMovies"][removeMovie - 1].Remove();

                        //Saving and Closing JSON File
                        string output = JsonConvert.SerializeObject(jsonArray, Formatting.Indented);
                        File.WriteAllText(@"List.json", output);
                        //Saving and Closing JSON File

                        Console.Clear();
                        AddMovie();
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        MainMenu.StaffMenu();
                        break;
                    }
            }
        }

        public static void MovieType()
        {
            string OPT;
            Console.WriteLine("Please choose an option to continue:");
            Console.WriteLine("1. 2D");
            Console.WriteLine("2. 3D");
            Console.WriteLine("3. IMAX");
            Console.Write("Input: ");

            OPT = Console.ReadLine().ToLower();
            Console.Clear();

            switch (OPT)
            {
                case "1":
                    {
                        MovieList(1);
                        break;
                    }

                case "2":
                    {
                        MovieList(1);
                        break;
                    }

                case "3":
                    {
                        MovieList(1);
                        break;
                    }
            }
        }
        // End Main Menu
        //Choose Movie
        public static void MovieList(int previousScreen)
        {
            var JsonString = File.ReadAllText(@"List.json");
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
                        Venue.venuedate(1, previousScreen);//Moet doorgeven aan VenueAndDate met movie ID en String met de naam van de film
                        break;
                    }
                case "2":
                    {
                        Venue.venuedate(2, previousScreen);
                        break;
                    }
                case "3":
                    {
                        Venue.venuedate(3, previousScreen);
                        break;
                    }
                case "4":
                    {
                        Venue.venuedate(4, previousScreen);
                        break;
                    }
                case "5":
                    {
                        Venue.venuedate(5, previousScreen);
                        break;
                    }
                case "6":
                    {
                        Venue.venuedate(6, previousScreen);
                        break;
                    }
                case "7":
                    {
                        Venue.venuedate(7, previousScreen);
                        break;
                    }
                case "8":
                    {
                        Venue.venuedate(8, previousScreen);
                        break;
                    }
                case "9":
                    {
                        Venue.venuedate(9, previousScreen);
                        break;
                    }
                case "10":
                    {
                        Venue.venuedate(10, previousScreen);
                        break;
                    }
                case "11":
                    {
                        if (previousScreen == 1)
                        {
                            MainMenu.CustomerMenu();
                            break;
                        }
                        if (previousScreen == 2)
                        {
                            MainMenu.Manager();
                            break;
                        }
                        if (previousScreen == 3)
                        {
                            MainMenu.Employee();
                            break;
                        }
                        break;
                    }
            }
        }
    }
    class SeatOptions
    {
        //Choose Seat
        public static void ChooseSeat(int hall, string movie, int previousScreen, string selectedSeats, string[] selectedSeatsArray, string error, int max)
        {
            // Choose Seat Console Text
            string input;
            Console.WriteLine("\nSelected Movie: " + movie);
            Console.WriteLine("\nAvailable Seats:");

            var JObject1 = JObject.Parse(File.ReadAllText(@"Seats.json"));
            var seats = JObject1.SelectToken($"$.SeatsHall{hall}").Values<string>().ToList();
            PrintSeats(hall);

            // End Show all Seats

            // Colored Selected Seats
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n     " + error);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n     Currently selected seats:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    " + selectedSeats);
            Console.ForegroundColor = ConsoleColor.Gray;
            // End Colored Selected Seats

            Console.WriteLine("\n\nPress 1: Choose Seat");
            Console.WriteLine("Press 2: Reset");
            Console.WriteLine("Press 3: Pay");
            Console.WriteLine("Press 4: Back");
            Console.Write("\nInput: ");

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

                        // Check if seat exist
                        if (seatNumberINT > seats.Count || seatNumberINT <= 0)
                        {
                            error = "Error, seat does not exist.";
                            Console.Clear();
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, error, max);
                            break;
                        }

                        // Check if value exists
                        else if (seatNumber + "R" == seats[seatNumberINT - 1])
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
                        else
                        {
                            selectedSeats += seatNumber + " ";
                            dynamic jsonSeats = JsonConvert.DeserializeObject(File.ReadAllText(@"Seats.json"));
                            jsonSeats[$"SelectedSeats"][max - 1] = seatNumber;
                            string output = JsonConvert.SerializeObject(jsonSeats, Formatting.Indented);
                            File.WriteAllText(@"Seats.json", output);

                            jsonSeats[$"SeatsHall{hall}"][seatNumberINT - 1] = seatNumber + "R";
                            string output1 = JsonConvert.SerializeObject(jsonSeats, Formatting.Indented);
                            File.WriteAllText(@"Seats.json", output1);

                            Console.Clear();
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, null, max - 1);
                            break;
                        }
                        // End Checker
                    }
                case "2":
                    {
                        Console.Clear();
                        ResetSelectedSeats(hall);
                        ChooseSeat(hall, movie, previousScreen, null, new string[5], null, 5);
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        ResetSelectedSeats();
                        PaymentSettings.Payment();
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        ResetSelectedSeats(hall);
                        MovieOptions.MovieList(previousScreen);
                        break;
                    }
            }
            // End User Input Oucome
        }
        //End Choose Seat

        public static void ResetSeats()
        {
            for (int i = 5; i > 0; i--)
            {
                dynamic jsonSelectedSeats = JsonConvert.DeserializeObject(File.ReadAllText(@"Seats.json"));
                jsonSelectedSeats[$"SelectedSeats"][i - 1] = "0";
                string output1 = JsonConvert.SerializeObject(jsonSelectedSeats, Formatting.Indented);
                File.WriteAllText(@"Seats.json", output1);
            }

            dynamic jsonSeatsHalls = JsonConvert.DeserializeObject(File.ReadAllText(@"Seats.json"));
            for (int i = 1; i <= 500; i++)
            {
                if (i <= 150)
                {
                    jsonSeatsHalls[$"SeatsHall1"][i - 1] = i + "";
                    jsonSeatsHalls[$"SeatsHall2"][i - 1] = i + "";
                    jsonSeatsHalls[$"SeatsHall3"][i - 1] = i + "";

                }
                if (i > 150 && i <= 300)
                {
                    jsonSeatsHalls[$"SeatsHall2"][i - 1] = i + "";
                    jsonSeatsHalls[$"SeatsHall3"][i - 1] = i + "";
                }
                if (i > 300 && i <= 500)
                {
                    jsonSeatsHalls[$"SeatsHall3"][i - 1] = i + "";
                }
            }
            string output = JsonConvert.SerializeObject(jsonSeatsHalls, Formatting.Indented);
            File.WriteAllText(@"Seats.json", output);
        }

        public static void ResetSelectedSeats(int hall)
        {
            var JObject1 = JObject.Parse(File.ReadAllText(@"Seats.json"));
            var seats = JObject1.SelectToken($"$.SeatsHall{hall}").Values<string>().ToList();
            var selectedSeatsList = JObject1.SelectToken($"$.SelectedSeats").Values<string>().ToList();

            foreach (string selectedSeat in selectedSeatsList)
            {
                int selectedSeatInt = Convert.ToInt32(selectedSeat);
                string chosenSeat = selectedSeat + "R";
                if (selectedSeatInt > 0 && chosenSeat == seats[selectedSeatInt - 1])
                {
                    dynamic jsonReservedSeats = JsonConvert.DeserializeObject(File.ReadAllText(@"Seats.json"));
                    jsonReservedSeats[$"SeatsHall{hall}"][selectedSeatInt - 1] = selectedSeat;
                    string output = JsonConvert.SerializeObject(jsonReservedSeats, Formatting.Indented);
                    File.WriteAllText(@"Seats.json", output);
                }
            }

            ResetSelectedSeats();
        }

        public static void ResetSelectedSeats()
        {
            for (int i = 5; i > 0; i--)
            {
                dynamic jsonSelectedSeats = JsonConvert.DeserializeObject(File.ReadAllText(@"Seats.json"));
                jsonSelectedSeats[$"SelectedSeats"][i - 1] = "0";
                string output1 = JsonConvert.SerializeObject(jsonSelectedSeats, Formatting.Indented);
                File.WriteAllText(@"Seats.json", output1);
            }
        }

        public static void PrintSeats(int hall)
        {
            int maxSeats = 0;
            if (hall == 1)
            {
                maxSeats = 150;
            }
            else if (hall == 2)
            {
                maxSeats = 300;
            }
            else if (hall == 3)
            {
                maxSeats = 500;
            }

            var JObject1 = JObject.Parse(File.ReadAllText(@"Seats.json"));
            var seats = JObject1.SelectToken($"$.SeatsHall{hall}").Values<string>().ToList();

            for (int z = 0; z < maxSeats; z++)
            {
                if (z % 10 == 0 && z < 10)
                {
                    Console.WriteLine(new string(' ', 25));
                    Console.Write(new string(' ', 25));
                }

                if (z % 10 == 0 && z < 100 && z >= 10)
                {
                    Console.WriteLine(new string(' ', 20));
                    Console.Write(new string(' ', 20));
                }

                if (z % 10 == 0 && z >= 100)
                {
                    Console.WriteLine(new string(' ', 15));
                    Console.Write(new string(' ', 15));
                }

                if (seats[z] == z + 1 + "R")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(z + 1 + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(seats[z] + " ");
                }
            }
        }
    }
    class Venue
    {
        public static void VenueAndDate(int MViD, string MovieName, int previousScreen)//Dit is de nieuwe Venue and Date
            {
                string[] movieDays = new string[5];
                movieDays[0] = "Monday";
                movieDays[1] = "Tuesday";
                movieDays[2] = "Wednesday";
                movieDays[3] = "Thursday";
                movieDays[4] = "Friday";
                string[] movieTimes = new string[4];
                movieTimes[0] = "15:00";
                movieTimes[1] = "17:00";
                movieTimes[2] = "19:00";
                movieTimes[3] = "21:00";
                movieTimes[4] = "23:00";
                string[] MvDTime = new string[(movieDays.Length * movieTimes.Length)];
                int counterD = 0;
                int counterT = 0;
                for (int i = 0; i < MvDTime.Length; i++)
                {
                    if (counterD > 4)
                    {
                        counterD = 0;
                    }
                    if (counterT > 4)
                    {
                        counterT = 0;
                        counterD++;
                    }
                    MvDTime[i] = movieDays[counterD] + " / " + movieTimes[counterT];
                    counterT++;
                }
                if (MViD == 1)
                {
                    VnDFrontend(MovieName, MvDTime[0], MvDTime[24], MvDTime[10], previousScreen);
                }
                if (MViD == 2)
                {
                    VnDFrontend(MovieName, MvDTime[24], MvDTime[3], MvDTime[15], previousScreen);
                }
                if (MViD == 3)
                {
                    VnDFrontend(MovieName, MvDTime[2], MvDTime[22], MvDTime[0], previousScreen);
                }
                if (MViD == 4)
                {
                    VnDFrontend(MovieName, MvDTime[12], MvDTime[6], MvDTime[24], previousScreen);
                }
                if (MViD == 5)
                {
                    VnDFrontend(MovieName, MvDTime[5], MvDTime[13], MvDTime[1], previousScreen);
                }
                if (MViD == 6)
                {
                    VnDFrontend(MovieName, MvDTime[19], MvDTime[14], MvDTime[10], previousScreen);
                }
                if (MViD == 7)
                {
                    VnDFrontend(MovieName, MvDTime[7], MvDTime[23], MvDTime[2], previousScreen);
                }
                if (MViD == 8)
                {
                    VnDFrontend(MovieName, MvDTime[22], MvDTime[10], MvDTime[3], previousScreen);
                }
                if (MViD == 9)
                {
                    VnDFrontend(MovieName, MvDTime[6], MvDTime[15], MvDTime[7], previousScreen);
                }
                if (MViD == 10)
                {
                    VnDFrontend(MovieName, MvDTime[23], MvDTime[0], MvDTime[22], previousScreen);
                }


        }
        public static void VnDFrontend(string MovieName, string Date, string Date2, string Date3, int previousScreen)//Dit hoort bij de nieuwe venue and date
        {
            Console.WriteLine("You chose the movie: " + MovieName);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("This movie plays on:");
            Console.WriteLine("1. Venue 1 " + Date + "\n" + "2. Venue 2 " + Date2 + "\n" + "3. Venue 3 " + Date3);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please type in the number of your choice to continue");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                SeatOptions.ChooseSeat(1, MovieName, previousScreen, null, new string[5], null, 5);
            }//De choose seat is nog niet aangepast om ook een datum aan te nemen, wanneer dat is gedaan kan hier ook de date worden meegegeven
            if (choice == "2")
            {
                SeatOptions.ChooseSeat(2, MovieName, previousScreen, null, new string[5], null, 5);
            }
            if (choice == "3")
            {
                SeatOptions.ChooseSeat(3, MovieName, previousScreen, null, new string[5], null, 5);
            }

        }



        public static void venuedate(int MViD, int previousScreen)
        {
            Tuple<int, string>[] VenueMVlist = new Tuple<int, string>[10];
            string[] MVList = new string[10] { "Jumanji", "Harry Potter", "Ride Along 2", "Spencer Confidential", "Fast & Furious", "6 Underground", "Deadpool 2", "Death at a Funeral", "Rush hour 3", "The Dark Knight" };
            for (int i = 0; i < 10; i++)
            {
                if (i < 3)
                {
                    VenueMVlist[i] = Tuple.Create(1, MVList[i]);
                }
                else if (i < 6)
                {
                    VenueMVlist[i] = Tuple.Create(2, MVList[i]);
                }
                else
                {
                    VenueMVlist[i] = Tuple.Create(3, MVList[i]);
                }

            }
            string[] mvTimes = new string[5] { "Wednesday: 11:30 - 16:00 - 19:00 ", "Thursday: 11:30 - 16:00 - 19:00", "Tuesday:  11:30 - 16:00 - 19:00", "Monday: 11:30 - 16:00 - 19:00", "Friday: 11:30 - 16:00 - 19:00" };
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
                if (Choice == "venue1/11:30" || Choice == "venue1/16:00" || Choice == "venue1/19:00")
                {
                    SeatOptions.ChooseSeat(1, "Jumanji", previousScreen, null, new string[5], null, 5);
                }
                else if (Choice == "venue3/11:30" || Choice == "venue3/16:00" || Choice == "venue3/19:00")
                {
                    SeatOptions.ChooseSeat(3, "Jumanji", previousScreen, null, new string[5], null, 5);
                }

            }
            else if (MViD == 2)
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
                if (Choice == "venue1/11:30" || Choice == "venue1/16:00" || Choice == "venue1/19:00")
                {
                    SeatOptions.ChooseSeat(1, "Harry Potter", previousScreen, null, new string[5], null, 5);
                }
                else if (Choice == "venue2/11:30" || Choice == "venue2/16:00" || Choice == "venue2/19:00")
                {
                    SeatOptions.ChooseSeat(2, "Harry Potter", previousScreen, null, new string[5], null, 5);
                }
            }
            else if (MViD == 3)
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
                if (Choice == "venue2/11:30" || Choice == "venue2/16:00" || Choice == "venue2/19:00")
                {
                    SeatOptions.ChooseSeat(2, "Ride Along 2", previousScreen, null, new string[5], null, 5);
                }
                else if (Choice == "venue3/11:30" || Choice == "venue3/16:00" || Choice == "venue3/19:00")
                {
                    SeatOptions.ChooseSeat(3, "Ride Along 2", previousScreen, null, new string[5], null, 5);
                }
            }
            else if (MViD == 4)
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
                if (Choice == "venue1/11:30" || Choice == "venue1/16:00" || Choice == "venue1/19:00")
                {
                    SeatOptions.ChooseSeat(1, "Spencer Confidential", previousScreen, null, new string[5], null, 5);
                }
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
                if (Choice == "venue2/11:30" || Choice == "venue2/16:00" || Choice == "venue2/19:00")
                {
                    SeatOptions.ChooseSeat(2, "Fast & Furious", previousScreen, null, new string[5], null, 5);
                }
                else if (Choice == "venue3/11:30" || Choice == "venue3/16:00" || Choice == "venue3/19:00")
                {
                    SeatOptions.ChooseSeat(3, "Fast & Furious", previousScreen, null, new string[5], null, 5);
                }
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
                if (Choice == "venue1/11:30" || Choice == "venue1/16:00" || Choice == "venue1/19:00")
                {
                    SeatOptions.ChooseSeat(1, "6 Underground", previousScreen, null, new string[5], null, 5);
                }
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
                if (Choice == "venue2/11:30" || Choice == "venue2/16:00" || Choice == "venue2/19:00")
                {
                    SeatOptions.ChooseSeat(2, "Deadpool 2", previousScreen, null, new string[5], null, 5);
                }
            }
            else if (MViD == 8)
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
                if (Choice == "venue1/11:30" || Choice == "venue1/16:00" || Choice == "venue1/19:00")
                {
                    SeatOptions.ChooseSeat(1, "Death at a Funeral", previousScreen, null, new string[5], null, 5);
                }
            }
            else if (MViD == 9)
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
                if (Choice == "venue2/11:30" || Choice == "venue2/16:00" || Choice == "venue2/19:00")
                {
                    SeatOptions.ChooseSeat(2, "Rush Hour 3", previousScreen, null, new string[5], null, 5);
                }
                else if (Choice == "venue3/11:30" || Choice == "venue3/16:00" || Choice == "venue3/19:00")
                {
                    SeatOptions.ChooseSeat(3, "Rush Hour 3", previousScreen, null, new string[5], null, 5);
                }
            }
            else if (MViD == 10)
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
                if (Choice == "venue3/11:30" || Choice == "venue3/16:00" || Choice == "venue3/19:00")
                {
                    SeatOptions.ChooseSeat(3, "The Dark Knight", previousScreen, null, new string[5], null, 5);
                }
            }
        }
    }
    class PaymentSettings {
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
                        IncrDailyRevenue(10);
                    }
                    else
                    {

                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment();
                    }




                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment();
                }
            }

            if (num2 == 2)
            {

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
                        IncrDailyRevenue(10);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment();
                    }





                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment();
                }
            }

            if (num2 == 3)
            {

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
                        IncrDailyRevenue(10);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment();
                    }




                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment();
                }
            }

            if (num2 == 4)
            {

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
                        IncrDailyRevenue(10);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment();
                    }




                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment();
                }
            }

            if (num2 == 5)
            {

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
                        IncrDailyRevenue(10);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment();
                    }




                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment();
                }
            }

            if (num2 == 6)
            {

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
                        IncrDailyRevenue(10);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment();
                    }




                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment();
                }
            }
        }



        public static void Offers()
        {
            string input;
            Console.WriteLine("These are our offers:\r\n");
            Console.WriteLine("10% Discount (Valid for 65+, teens (12 to 17)\r\n");
            Console.WriteLine("Press 1: Get Discount");
            Console.WriteLine("Press 2: Back");
            Console.Write("Input: ");

            input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        MovieOptions.MovieType();
                        break;
                    }
                case "2":
                    {
                        MainMenu.CustomerMenu();
                        break;
                    }
            }
        }

        public static void ShowDailyRevenue(int i)
        {
            string input;
            var currentDailyRevenue = File.ReadAllText(@"DailyRevenue.json");
            var JObject1 = JObject.Parse(currentDailyRevenue);
            var DailyRevenue = JObject1.SelectToken("$.DailyRevenue").Value<int>();
            Console.WriteLine($"Today's revenue is ${DailyRevenue}.\r\n");
            Console.WriteLine("Press 1: Back");
            Console.Write("Input: ");

            input = Console.ReadLine();

            Console.Clear();

            switch (input)
            {
                case "1":
                    {
                        if (i == 1)
                        {
                            MainMenu.Manager();
                            break;
                        }
                        else
                        {
                            MainMenu.Employee();
                            break;
                        }
                    }
            }
        }

        public static void IncrDailyRevenue(int i)
        {
            var currentDailyRevenue = File.ReadAllText(@"DailyRevenue.json");
            dynamic DailyRevenue = JsonConvert.DeserializeObject(currentDailyRevenue);

            DailyRevenue[@"DailyRevenue"] += i;

            string output = JsonConvert.SerializeObject(DailyRevenue, Formatting.Indented);
            File.WriteAllText("DailyRevenue.json", output);

            Console.Clear();
            MainMenu.BeginMenu();
        }

        public static void ResetRevenue()
        {
            var currentDailyRevenue = File.ReadAllText(@"DailyRevenue.json");
            dynamic DailyRevenue = JsonConvert.DeserializeObject(currentDailyRevenue);

            DailyRevenue[@"DailyRevenue"] = 0;

            string output = JsonConvert.SerializeObject(DailyRevenue, Formatting.Indented);
            File.WriteAllText("DailyRevenue.json", output);
        }
    }
}

