using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("==                                    ==");
        Console.WriteLine("==              WELCOME               ==");
        Console.WriteLine("==                TO                  ==");
        Console.WriteLine("==       Regent Health Surgery        ==");
        Console.WriteLine("==                                    ==");
        Console.WriteLine("========================================");

        string username  = "Doctor1";
        string password = "Regent_2026";

        for (int attempts = 0; attempts < 3; attempts++)
        {
            Console.Write("username: ");
            string? inputUsername = Console.ReadLine();
            
            Console.Write("password: ");
            string? inputPassword = Console.ReadLine();

            if (inputUsername == username && inputPassword == password)
            {
                var doctor = new Doctor1.Doctor1();
                doctor.Login();
                break;
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
                if (attempts == 2)
                {
                    Console.WriteLine("Too many failed attempts. Exiting program.");
                    Environment.Exit(0);
                }
            }
        }
    }
}