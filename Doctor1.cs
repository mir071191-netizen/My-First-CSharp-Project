using System;

namespace Doctor1
{
    public class Doctor1
    {
        public void Login()
        {
            Console.WriteLine("Login successful! Welcome, Doctor1.");
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. View Patient Records");
                Console.WriteLine("2. Schedule Appointments");
                Console.WriteLine("3. Logout");
                Console.Write("Enter your choice (1-3): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Viewing patient records...");
                        PatientRecords records = new PatientRecords();
                        records.ViewRecords();
                        break;
                    case "2":
                        Console.WriteLine("Scheduling appointments...");
                        AppointmentScheduler scheduler = new AppointmentScheduler();
                        scheduler.ScheduleAppointments();
                        break;
                    case "3":
                        Console.WriteLine("Logging out...");
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }
            }
        }
    }
}