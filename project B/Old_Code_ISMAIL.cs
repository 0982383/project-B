/*
Using System;

namespace project_B
{
    public class UserInfo
    {
        public string Username;
        public string Password;

        public void Task1()
        {
            Console.WriteLine("Enter Username:");

        }
        public void Task2()
        {
            Console.WriteLine("Enter Password:");
        }

        public void Succes()
        {
            Console.WriteLine("Welcome Back " + Username);
        }
    }
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public int PhoneNumber;


        public void Guest()
        {
            Console.WriteLine("Guest");
        }
    }
    public class Movies
    {
        public int movieID;
        public string MovieName;
        public int MovieDuration;
        public double MoviePrice;

    }
    public class Reservation
    {
        public int OrderID;
        public string CustomerName;
        public string Seats;
        public string Movie;
        public int Price;


    }
    public class Payment
    {
        public string PaymentMethod;
        public string Price;
        public int OrderID;


    }
    public class Seats
    {
        public int Hall;
        public int SeatNumber;
        public int Row;
    }
    public class Hall
    {
        public int Seats;
        public int Rows;
        public string SpecialEffects;
    }
    public class Admin
    {
        public string Firstname;
        public string Lastname;
        public string Email;
        public int phonenumber;

        public void admin()
        {
            Console.WriteLine("Admin");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            UserInfo x = new UserInfo();

            x.Task1();
            x.Username = Console.ReadLine();

            x.Task2();
            x.Password = Console.ReadLine();
            x.Succes();
        }
    }
}
*/