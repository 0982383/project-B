using System;

public class mainMenu
{
	public void menuX()
	{
		bool repeat = false;
		Console.WriteLine("Welcome to our cinema application");
		Console.WriteLine("Are you a customer or employee?");
		Console.WriteLine("1.Customer");
		Console.WriteLine("2.Employee");
		Console.WriteLine("Exit");
		string userChoice = Console.ReadLine();
		switch (userChoice)
        {
			case "1":
				Console.WriteLine("Welcome");
				Console.WriteLine("Press 1 to see available movies");
				Console.WriteLine("If u want to go back to main menu press 2");
				ConsoleKeyInfo keyPressed;
				keyPressed = Console.ReadKey();
				if (keyPressed.Key == ConsoleKey.D1 || keyPressed.Key == ConsoleKey.NumPad1)
                {

                }
				else if (keyPressed.Key == ConsoleKey.D2 || keyPressed.Key == ConsoleKey.NumPad2)
                {
					repeat = false;
                }
				Console.Clear();
				this.menuX();
				break;
			case "2":
				Console.WriteLine("Welcome");
				Console.WriteLine("1. Manager");
				Console.WriteLine("2. Employee");
				break;



        }
		
	}
}
