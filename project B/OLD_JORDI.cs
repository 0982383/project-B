/*
using System;
using System.Collections;
using System.Linq;
using System.Text;

public class startMenu
{
    static void Main(string[] args)
    {
        BeginMen();
    }

    public static void BeginMen()
    {
        string OPT;
        Console.WriteLine("Welcome to cinema application");
        Console.WriteLine("Please choose a option to continue");
        Console.WriteLine("1. Customer");
        Console.WriteLine("2. Staff");

        OPT = Console.ReadLine().ToLower();
        Console.Clear();

        switch (OPT)

        {
            case "1":
            case "customer":
                {
                    string OPT2;
                    Console.WriteLine("Welcome customer, what would you like to do?");
                    Console.WriteLine("Please choose a number to continue");
                    Console.WriteLine("1. See available movies");
                    Console.WriteLine("2. See offers");
                    Console.WriteLine("3. About us");

                    OPT2 = Console.ReadLine();
                    Console.Clear();

                    switch (OPT2)
                    {
                        case "1":
                            {
                                MovieList();
                                break;
                            }
                        case "2":
                            {
                                Offers();
                                break;
                            }
                        case "3":
                            {
                                AboutUs();
                                break;
                            }
                    }
                    break;
                }
            case "2":
            case "staff":
                {
                    string OPT3;
                    Console.WriteLine("Welcome, do you wish to continue as manager or employee?");
                    Console.WriteLine("1. Manager");
                    Console.WriteLine("2. Employee");

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
                    break;
                }
        }


    }

    public static void Customer()
    {

    }

    public static void Staff()
    {

    }

    public static void MovieList()
    {

    }
    public static void Offers()
    {

    }
    public static void AboutUs()
    {

    }
    public static void Employee()
    {

    }
    public static void Manager()
    {

    }
}
*/