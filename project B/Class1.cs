using System;
using System.Collections.Generic;
using System.Text;

namespace project_B
{
    class Class1
    {
    }
}
namespace ConsoleAppCinema1
{
    //Main class
    class Program
    {
        // Entry point
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu()
                    ;
            }
        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome To Our Cinema Application!");
            Console.WriteLine("1] Log in as Customer.");
            Console.WriteLine("2] Log in as employee.");
            Console.WriteLine("3] Log in as manager.");
            Console.WriteLine("4] Exit.");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    customer();
                    return true;
                case "2":
                    employee();
                    return true;
                case "3":
                    manager();
                    return true;
                case "4":
                    return false;
                default:
                    return true; 

            }
        }
        public static void customer()
        {
            Console.Clear();
            Console.WriteLine("Welcome customer!");
        }
        public static void employee()
        {
            Console.Clear();
            Console.WriteLine("Welcome employee!");
        }
        public static void manager()
        {
            Console.Clear();
            Console.WriteLine("Welcome manager!");
        }
    }
    public class employees
    {

    }
    public class customer
    {

    }
    public class Jake
    {

    }
    public class Movies
    {



    }

}  
