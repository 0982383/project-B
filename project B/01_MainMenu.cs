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
            BeginMenu(new Clickstream());
        }

        // Main Menu
        public static void BeginMenu(Clickstream userClick)
        {
            // Initialize Clickstream

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
                        userClick.AddInput("Customer Menu => ");
                        CustomerMenu(userClick);
                        break;
                    }

                case "2":
                    {
                        userClick.AddInput("Login Screen => ");
                        LoginScreen(userClick);
                        break;
                    }

                case "3":
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        BeginMenu(userClick);
                        break;
                    }
            }
        }
        // Logging in(staff)
        public static void LoginScreen(Clickstream userClick)
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
                userClick.AddInput("Tom Customer Test => ");
                CustomerMenu(userClick);
            }
            else if (inputpassWord == account2)
            {
                Console.Clear();
                Console.WriteLine("You have logged in.");
                userClick.AddInput("Feuzi Customer Test => ");
                CustomerMenu(userClick);
            }
            else if (inputpassWord == account3)
            {
                Console.Clear();
                Console.WriteLine("You have logged in.");
                userClick.AddInput("Jordi Customer Test => ");
                CustomerMenu(userClick);
            }
            else if (inputpassWord == account4)
            {
                Console.Clear();
                Console.WriteLine("You have logged in.");
                userClick.AddInput("Ismail Staff Test => ");
                StaffMenu(userClick);
            }
            else if (inputpassWord == account5)
            {
                Console.Clear();
                Console.WriteLine("You have logged in.");
                userClick.AddInput("Patryck staff Test => ");
                StaffMenu(userClick);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have enterd wrong username/password. ");
                LoginScreen(userClick);

            }
        }
        // customer options
        public static void CustomerMenu(Clickstream userClick)
        { //Menu for customers
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
                        userClick.AddInput("Movie Type => ");//To movielist
                        MovieOptions.MovieType(userClick);
                        break;
                    }
                case "2":
                    {
                        userClick.AddInput("Offers => ");//To offers screen
                        PaymentSettings.Offers(userClick);
                        break;
                    }
                case "3":
                    {
                        userClick.AddInput("About Us => ");//To about us screen
                        AboutUs(userClick);
                        break;
                    }
                default:
                    {
                        CustomerMenu(userClick);
                        break;
                    }
            }
        }
        // staff options
        public static void StaffMenu(Clickstream userClick)
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
                        userClick.AddInput("Manager Screen => ");//To manager menu
                        Manager(userClick);
                        break;
                    }
                case "2":
                case "employee":
                    {
                        Console.Clear();
                        userClick.AddInput("Employee Screen => ");//To employee menu
                        Employee(userClick);
                        break;
                    }
                default:
                    {
                        StaffMenu(userClick);
                        break;
                    }
            }
        }

        public static void Manager(Clickstream userClick)
        {
            //Manager menu 
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
                        userClick.AddInput("Movie Type => ");//To choose movie screen
                        MovieOptions.MovieType(userClick);
                        break;
                    }
                case "2":
                    {
                        userClick.AddInput("Daily Revenue => ");
                        PaymentSettings.ShowDailyRevenue(1, userClick);//To show daily revenue screen
                        break;
                    }
                case "3":
                    {
                        userClick.AddInput("Staff Menu => ");//Back to first menu
                        StaffMenu(userClick);
                        break;
                    }
                default:
                    {
                        Manager(userClick);
                        break;
                    }
            }

        }

        public static void Employee(Clickstream userClick)
        {
            //Employee menu 
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
                        userClick.AddInput("Movie Type => ");//to movie selection screen
                        MovieOptions.MovieType(userClick);
                        break;
                    }
                case "2":
                    {
                        userClick.AddInput("Add/Remove Movie => ");//To add or remove movie screen
                        MovieOptions.AddMovie(userClick);
                        break;
                    }
                case "3":
                    {
                        userClick.AddInput("Daily Revenue => ");//To daily revenue screen 
                        PaymentSettings.ShowDailyRevenue(2, userClick);
                        break;
                    }
                case "4":
                    {
                        userClick.AddInput("Staff Menu => ");//Back to the first menu 
                        StaffMenu(userClick);
                        break;
                    }
                default:
                    {
                        Employee(userClick);
                        break;

                    }
            }
        }

        public static void AboutUs(Clickstream userClick)
        {   //About us screen showing some general information about the cinema
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
                        userClick.AddInput("Customer Menu => ");
                        CustomerMenu(userClick);
                        break;
                    }
                default:
                    {
                        AboutUs(userClick);
                        break;
                    }
            }
        }
    }
    class MovieOptions {
        public static void AddMovie(Clickstream userClick)
        {
            // calling json file to edit available movies
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
                        userClick.AddInput("Movie Added => ");
                        AddMovie(userClick);
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
                        userClick.AddInput("Movie Removed => ");
                        AddMovie(userClick);
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        userClick.AddInput("Staff Menu => ");
                        MainMenu.StaffMenu(userClick);
                        break;
                    }
                default:
                    {
                        AddMovie(userClick);
                        break;
                    }
            }
        }
        // choosing movie type before selecting movie
        public static void MovieType(Clickstream userClick)
        { // screen to select the way the client wants to watch the movie
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
                        userClick.AddInput("2D => ");
                        MovieList(1,userClick);
                        break;
                    }

                case "2":
                    {
                        userClick.AddInput("3D => ");
                        MovieList(1,userClick);
                        break;
                    }

                case "3":
                    {
                        userClick.AddInput("IMAX => ");
                        MovieList(1,userClick);
                        break;
                    }
                default:
                    {
                        MovieType(userClick);
                        break;
                    }
            }
        }
        // calling movie list + selecting venue
        public static void MovieList(int previousScreen, Clickstream userClick)
        {//shows the Movie list 
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
            //selection of the desired movie
            string input;
            input = Console.ReadLine();
            Console.Clear();


            switch (input)
            {
                case "1":
                    {
                        //VenueAndDate(int MViD, string MovieName, int previousScreen, Clickstream userClick)
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(1, previousScreen, userClick);//Moet doorgeven aan VenueAndDate met movie ID en String met de naam van de film
                        Venue.VenueAndDate(1,myList[0],previousScreen,userClick);
                        break;
                    }
                case "2":
                    {
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(2, previousScreen, userClick);
                        Venue.VenueAndDate(2, myList[1], previousScreen, userClick);
                        break;
                    }
                case "3":
                    {
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(3, previousScreen, userClick);
                        Venue.VenueAndDate(3, myList[2], previousScreen, userClick);
                        break;
                    }
                case "4":
                    {
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(4, previousScreen, userClick);
                        Venue.VenueAndDate(4, myList[3], previousScreen, userClick);
                        break;
                    }
                case "5":
                    {
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(5, previousScreen, userClick);
                        Venue.VenueAndDate(5, myList[4], previousScreen, userClick);
                        break;
                    }
                case "6":
                    {
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(6, previousScreen, userClick);
                        Venue.VenueAndDate(6, myList[5], previousScreen, userClick);
                        break;
                    }
                case "7":
                    {
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(7, previousScreen, userClick);
                        Venue.VenueAndDate(7, myList[6], previousScreen, userClick);
                        break;
                    }
                case "8":
                    {
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(8, previousScreen, userClick);
                        Venue.VenueAndDate(8, myList[7], previousScreen, userClick);
                        break;
                    }
                case "9":
                    {
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(9, previousScreen, userClick);
                        Venue.VenueAndDate(9, myList[8], previousScreen, userClick);
                        break;
                    }
                case "10":
                    {
                        userClick.AddInput("Venue and Date => ");
                        //Venue.venuedate(10, previousScreen, userClick);
                        Venue.VenueAndDate(10, myList[9], previousScreen, userClick);
                        break;
                    }
                case "11":
                    {
                        if (previousScreen == 1)
                        {
                            userClick.AddInput("Customer Menu => ");
                            MainMenu.CustomerMenu(userClick);
                            break;
                        }
                        if (previousScreen == 2)
                        {
                            userClick.AddInput("Manager Menu => ");
                            MainMenu.Manager(userClick);
                            break;
                        }
                        if (previousScreen == 3)
                        {
                            userClick.AddInput("Employee Menu => ");
                            MainMenu.Employee(userClick);
                            break;
                        }
                        break;
                    }
                default:
                    {
                        MovieList(1, userClick);
                        break;
                    }
            }
        }
    }
    class SeatOptions
    {
        //Choose Seat
        public static void ChooseSeat(int hall, string movie, int previousScreen, string selectedSeats, string[] selectedSeatsArray, string error, int max, string Date, Clickstream userClick)
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
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, error, max, Date, userClick);
                            break;
                        }

                        // Check if value exists
                        else if (seatNumber + "R" == seats[seatNumberINT - 1])
                        {
                            error = "Seat already selected.";
                            Console.Clear();
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, error, max, Date, userClick);
                            break;
                        }

                        // Check if max amount of seats does not exceed 5
                        else if (max <= 0)
                        {
                            error = "Max amount of seats selected";
                            Console.Clear();
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, error, max, Date, userClick);
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
                            userClick.AddInput($"Added Seat {seatNumberINT} => ");
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, null, max - 1, Date, userClick);
                            break;
                        }
                        // End Checker
                    }
                case "2":
                    {
                        Console.Clear();
                        ResetSelectedSeats(hall);
                        userClick.AddInput("Reset Seats => ");
                        ChooseSeat(hall, movie, previousScreen, null, new string[5], null, 5, Date, userClick);
                        break;
                    }
                case "3":
                    {
                        if (max == 5)
                        {
                            error = "No seats currently selected, please select a seat.";
                            Console.Clear();
                            ChooseSeat(hall, movie, previousScreen, selectedSeats, selectedSeatsArray, error, max, Date, userClick);
                        }
                        else
                        {
                            userClick.AddInput("Payment Screen => ");
                            Console.Clear();
                            ResetSelectedSeats();
                            PaymentSettings.Payment(userClick);
                            break;
                        }
                        break;
                    }
                case "4":
                    {
                        userClick.AddInput("Movie List => ");
                        Console.Clear();
                        ResetSelectedSeats(hall);
                        MovieOptions.MovieList(previousScreen, userClick);
                        break;
                    }
               
            }
            // End User Input Oucome
        }
        //End Choose Seat

        public static void ResetSeats()
        { //Resets all seats to be available again 
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
        { //Resets selected seats to go from occupied to available 
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
        { //Shows the seats in the venues
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
        public static void VenueAndDate(int MViD, string MovieName, int previousScreen, Clickstream userClick)//Dit is de nieuwe Venue and Date
            {
                string[] movieDays = new string[5];
                movieDays[0] = "Monday";
                movieDays[1] = "Tuesday";
                movieDays[2] = "Wednesday";
                movieDays[3] = "Thursday";
                movieDays[4] = "Friday";
                string[] movieTimes = new string[5];
                movieTimes[0] = "15:00";
                movieTimes[1] = "17:00";
                movieTimes[2] = "19:00";
                movieTimes[3] = "21:00";
                movieTimes[4] = "23:00";
                string[] MvDTime = new string[(movieDays.Length * movieTimes.Length)];
                int counterD = 0;
                int counterT = 0;
                for (int i = 0; i < MvDTime.Length; i++) //Creating a array with the possible days and times for movies to play at the venues
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
                    VnDFrontend(MovieName, MvDTime[0], MvDTime[24], MvDTime[10], previousScreen, userClick);
                }
                if (MViD == 2)
                {
                    VnDFrontend(MovieName, MvDTime[24], MvDTime[3], MvDTime[15], previousScreen, userClick);
                }
                if (MViD == 3)
                {
                    VnDFrontend(MovieName, MvDTime[2], MvDTime[22], MvDTime[0], previousScreen, userClick);
                }
                if (MViD == 4)
                {
                    VnDFrontend(MovieName, MvDTime[12], MvDTime[6], MvDTime[24], previousScreen, userClick);
                }
                if (MViD == 5)
                {
                    VnDFrontend(MovieName, MvDTime[5], MvDTime[13], MvDTime[1], previousScreen, userClick);
                }
                if (MViD == 6)
                {
                    VnDFrontend(MovieName, MvDTime[19], MvDTime[14], MvDTime[10], previousScreen, userClick);
                }
                if (MViD == 7)
                {
                    VnDFrontend(MovieName, MvDTime[7], MvDTime[23], MvDTime[2], previousScreen, userClick);
                }
                if (MViD == 8)
                {
                    VnDFrontend(MovieName, MvDTime[22], MvDTime[10], MvDTime[3], previousScreen, userClick);
                }
                if (MViD == 9)
                {
                    VnDFrontend(MovieName, MvDTime[6], MvDTime[15], MvDTime[7], previousScreen, userClick);
                }
                if (MViD == 10)
                {
                    VnDFrontend(MovieName, MvDTime[23], MvDTime[0], MvDTime[22], previousScreen, userClick);
                }


        }
        public static void VnDFrontend(string MovieName, string Date, string Date2, string Date3, int previousScreen, Clickstream userClick)//The front end for the Venue and date selection screen
        {
            Console.WriteLine("You chose the movie: " + MovieName);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("This movie plays on:");
            Console.WriteLine("1. Venue 1 " + Date + "\n" + "2. Venue 2 " + Date2 + "\n" + "3. Venue 3 " + Date3);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Please type in the number of your choice to continue");
            string choice = Console.ReadLine();
            if (choice == "1")//Giving the Date and Venue selection to the choose seat screen
            {
                userClick.AddInput("Choose Seat => ");
                SeatOptions.ChooseSeat(1, MovieName, previousScreen, null, new string[5], null, 5, Date , userClick);
            }
            if (choice == "2")
            {
                userClick.AddInput("Choose Seat => ");
                SeatOptions.ChooseSeat(1, MovieName, previousScreen, null, new string[5], null, 5, Date2, userClick);
            }
            if (choice == "3")
            {
                userClick.AddInput("Choose Seat => ");
                SeatOptions.ChooseSeat(1, MovieName, previousScreen, null, new string[5], null, 5, Date3, userClick);
            }

        }
    }
    class PaymentSettings {
        public static void Payment(Clickstream userClick)
        {
            //Selecting a payment option 

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
                {  // The transaction part of the payment process
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
                        userClick.AddInput("Bought With Paypal => ");
                        IncrDailyRevenue(10, userClick);
                    }
                    else
                    {

                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment(userClick);
                    }




                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment(userClick);
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
                        userClick.AddInput("Bought With IDeal => ");
                        IncrDailyRevenue(10, userClick);                       
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment(userClick);
                    }





                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment(userClick);
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
                        userClick.AddInput("Bought With Creditcard => ");
                        IncrDailyRevenue(10, userClick);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment(userClick);
                    }




                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment(userClick);
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
                        userClick.AddInput("Bought With Bitcoin=> ");
                        IncrDailyRevenue(10, userClick);  
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment(userClick);
                    }




                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment(userClick);
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
                        userClick.AddInput("Bought With Apple Pay => ");
                        IncrDailyRevenue(10, userClick);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment(userClick);
                    }




                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment(userClick);
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
                        userClick.AddInput("Bought With Google Pay => ");
                        IncrDailyRevenue(10, userClick);                      
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("you did not type the space bar :/");
                        Payment(userClick);
                    }




                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("you did not press enter :/");
                    Payment(userClick);
                }
            }
            else
            {
                Console.Clear();
                Payment(userClick);
                
            }
        }



        public static void Offers(Clickstream userClick)
        {  // Screen showing offers like discounts 
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
                        userClick.AddInput("Movie Type => ");
                        MovieOptions.MovieType(userClick);
                        break;
                    }
                case "2":
                    {
                        userClick.AddInput("Customer Menu => ");
                        MainMenu.CustomerMenu(userClick);
                        break;
                    }
                default:
                    {
                        Offers(userClick);
                        break;
                    }
            }
        }

        public static void ShowDailyRevenue(int i, Clickstream userClick)
        {  //Shows the daily revenue which is stored in a JSON file
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
                            userClick.AddInput("Manager Menu => ");
                            MainMenu.Manager(userClick);
                            break;
                        }
                        else
                        {
                            userClick.AddInput("Employee Menu => ");
                            MainMenu.Employee(userClick);
                            break;
                        }
                    }
            }
        }

        public static void IncrDailyRevenue(int i, Clickstream userClick)
        { // Method used to add to the daily revenue
            var currentDailyRevenue = File.ReadAllText(@"DailyRevenue.json");
            dynamic DailyRevenue = JsonConvert.DeserializeObject(currentDailyRevenue);

            DailyRevenue[@"DailyRevenue"] += i;

            string output = JsonConvert.SerializeObject(DailyRevenue, Formatting.Indented);
            File.WriteAllText("DailyRevenue.json", output);

            Console.Clear();
            userClick.AddToJson();
            MainMenu.BeginMenu(new Clickstream());
        }

        public static void ResetRevenue()
        { //Resets the daily Revenue to 0
            var currentDailyRevenue = File.ReadAllText(@"DailyRevenue.json");
            dynamic DailyRevenue = JsonConvert.DeserializeObject(currentDailyRevenue);

            DailyRevenue[@"DailyRevenue"] = 0;

            string output = JsonConvert.SerializeObject(DailyRevenue, Formatting.Indented);
            File.WriteAllText("DailyRevenue.json", output);
        }
    }

    class Clickstream
    {
        private string Input;

        public Clickstream()
        {
            Input = "";
        }
        
        public void AddInput(string addedInput)
        {
            Input += addedInput;
        }

        public void AddToJson()
        {
            //Opening JSON file that needs to be modified
            var initialJSON = File.ReadAllText(@"ClickStream.json");
            dynamic jsonArray = JsonConvert.DeserializeObject(initialJSON);
            int counter = 0;
            if (jsonArray.ClickStreamOfUsers != null && jsonArray.ClickStreamOfUsers.Count == 0)
            {
                counter = 1;
            }
            else
            {
                counter = jsonArray.ClickStreamOfUsers.Count + 1;
            }

            string jsonInput = $"User {counter}) {Input}";
            //Adding the movie
            jsonArray["ClickStreamOfUsers"].Add(jsonInput);

            //Saving and Closing JSON File
            string output = JsonConvert.SerializeObject(jsonArray, Formatting.Indented);
            File.WriteAllText(@"ClickStream.json", output);
            //Saving and Closing JSON File
        }
    }
}

