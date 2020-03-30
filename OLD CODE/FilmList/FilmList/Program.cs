using System;

namespace ConsoleApp7
{

    class Program
    {
        static void Main(string[] args)

        {
            bool showMovie = true;
            while (showMovie)
            {
                showMovie = MovieList();
            }
        }
        // Showing all the movies avalaible
        private static bool MovieList()
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
            Console.WriteLine("11) Exit");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.Write("\r\nSelect Movie: ");




            // if-statements for calling the different methodes
            switch (Console.ReadLine())
            {
                case "1":

                    Jumanji();
                    return true;
                case "2":
                    HarryPotter();
                    return true;
                case "3":
                    RideAlong2();
                    return true;
                case "4":
                    SpencerConfidential();
                    return true;
                case "5":
                    FastAndFurious();
                    return true;
                case "6":
                    SixUnderground();
                    return true;
                case "7":
                    DeadPool2();
                    return true;
                case "8":
                    Funeral();
                    return true;
                case "9":
                    RushHou3();
                    return true;
                case "10":
                    TheDarkKnight();
                    return true;
                case "11":
                    return false;
                default:
                    return true;
            }
        }
        // command line for showing the different "screens"
        private static string ShowMovie()
        {
            return Console.ReadLine();
        }

        // all the methodes for each movie 
        private static void Jumanji()
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
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void HarryPotter()
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
            char[] charArray = ShowMovie().ToCharArray();
        }

        private static void RideAlong2()
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
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void SpencerConfidential()
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
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void FastAndFurious()
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
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void SixUnderground()
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
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void DeadPool2()
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
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void Funeral()
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
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void RushHou3()
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
            char[] charArray = ShowMovie().ToCharArray();

        }

        private static void TheDarkKnight()
        {
            Console.Clear();
            Console.WriteLine("The Dark Knight");

            Console.WriteLine("Duration: 152 minutes");
            Console.WriteLine("Date: 3-4-2020");
            Console.WriteLine("Time: 11:30 - 16:00 - 19:00");
            Console.WriteLine("Press Enter to return to MovieList");
            char[] charArray = ShowMovie().ToCharArray();

        }
    }
}