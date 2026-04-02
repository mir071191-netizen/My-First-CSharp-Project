using System;

namespace Doctor1
{
    public class AppointmentScheduler
    {
        public void ScheduleAppointments()
        {
            Console.WriteLine("\n--- New Appointment ---");
            Console.Write("Enter patient first name: ");
            string? patientFirstName = Console.ReadLine();
            Console.Write("Enter patient last name: ");
            string? patientLastName = Console.ReadLine();
            
            Console.Write("Enter Patient AGE: ");
            int.TryParse(Console.ReadLine(), out int patientAge);
            switch (patientAge)
            {
                case int n when (n >= 0 && n <= 10):
                    Console.WriteLine("Patient is a child.");
                    break;
                case int n when (n > 10 && n <= 17):
                    Console.WriteLine("Patient is a teenager.");
                    break;
                case int n when (n > 17 && n <= 64):
                    Console.WriteLine("Patient is an adult.");
                    break;
                case int n when (n > 64):
                    Console.WriteLine("Patient is a senior.");
                    break;
            }
            Console.Write("Enter patient Email: ");
            string? patientEmail = Console.ReadLine();
            if (patientEmail.Contains("@RegentHealth.com"))
                Console.WriteLine("Valid email address.");
            else
                Console.WriteLine("Invalid email format. Should be @RegentHealth.com");
            Console.Write("Enter patient phone number (10 digits): ");
            string? patientPhone = Console.ReadLine();
            Console.WriteLine("Please enter the patient's address (Street, City, State, Postal Code):");
            string? patientAddress = Console.ReadLine();
            Console.WriteLine("\nPlease choose an appointment type:");
            var appointmentTypes = new List<(string name, int price)>
            {
                ("General Consultation", 35),
                ("Nurse Check-up", 20),
                ("Blood Test", 15),
                ("Specialist Consultation", 60)
            };
            appointmentTypes = appointmentTypes.OrderByDescending(t => t.price).ToList();
            for (int i = 0; i < appointmentTypes.Count; i++)
            {
                Console.WriteLine($"{i+1}. {appointmentTypes[i].name} {appointmentTypes[i].price}£");
            }
            string? typeChoice = Console.ReadLine();
            string selectedType = "";
            if (int.TryParse(typeChoice, out int choiceIndex) && choiceIndex >= 1 && choiceIndex <= appointmentTypes.Count)
            {
                selectedType = appointmentTypes[choiceIndex - 1].name;
            }
            else
            {
                Console.WriteLine("Invalid choice. Defaulting to General Consultation.");
                selectedType = "General Consultation";
            }
            Console.Write("Enter appointment date (YYYY-MM-DD): ");
            string? inputDate = Console.ReadLine();
            DateTime.TryParse(inputDate, out DateTime appointmentDateTime);
            PatientRecords.SaveFirstName = patientFirstName;
            PatientRecords.SaveLastName = patientLastName;
            PatientRecords.SaveAge = patientAge.ToString();
            PatientRecords.SaveEmail = patientEmail;
            PatientRecords.SavePhoneNumber = patientPhone;
            PatientRecords.SaveAddress = patientAddress;
            PatientRecords.SaveAppointmentDate = appointmentDateTime.ToShortDateString();
            PatientRecords.SaveAppointmentType = selectedType;
            Console.WriteLine("\nAppointment successfully saved!");
            Console.WriteLine("Press Enter to return to menu...");
            Console.ReadLine();
        }
    }
}