using System;

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
        public void Guest()
        {
            Console.WriteLine("Guest");
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
