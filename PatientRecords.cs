using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Doctor1
{
    public class PatientRecords
    {
      string ditails = "Correct!!!";
      public static string? SaveFirstName { get; set; }
      public static string? SaveLastName { get; set; }
      public static string? SaveAge { get; set; }
      public static string? SaveEmail { get; set; }
      public static string? SavePhoneNumber { get; set; }
      public static string? SaveAddress { get; set; }
      public static string? SaveCity { get; set; }
      public static string? SaveState { get; set; }
      public static string? SavePostCode { get; set;}
      public static string? SaveAppointmentDate { get; set; }
      public static string? SaveAppointmentType { get; set; }
    
     public void SavePatientRecords()
       {
        Console.WriteLine("Enter patient's first name:");
        SaveFirstName = Console.ReadLine();
        Console.WriteLine("Enter patient's last name:");
        SaveLastName = Console.ReadLine();
        Console.WriteLine("Enter patient's age:");
        SaveAge = Console.ReadLine();
        Console.WriteLine("Enter patient's email:");
        SaveEmail = Console.ReadLine();
        Console.WriteLine("Enter patient's phone number:");
        SavePhoneNumber = Console.ReadLine();
        Console.WriteLine("Enter patient's address:");
        SaveAddress = Console.ReadLine();
        Console.WriteLine("Enter patient's city:");
        SaveCity = Console.ReadLine();
        Console.WriteLine("Enter patient's state:");
        SaveState = Console.ReadLine();
        Console.WriteLine("Enter patient's post code:");
        SavePostCode = Console.ReadLine();
        }
     public string DisplayPatientRecords()
     {
        string records = $"First Name: {SaveFirstName}\nLast Name: {SaveLastName}\nAge: {SaveAge}\nEmail: {SaveEmail}\nPhone Number: {SavePhoneNumber}\nAddress: {SaveAddress}\nCity: {SaveCity}\nState: {SaveState}\nPost Code: {SavePostCode}";
        Console.WriteLine(records);
        Console.WriteLine("Confirm the patient records? (y/n)");
        
        string? confirmation = Console.ReadLine();
        if (confirmation == "y")
        {
            Console.WriteLine("Patient records saved successfully!");
        }
        else
        {
            Console.WriteLine("Patient records not saved.");
        }
        return records;
     }
     public void ViewRecords()
     {
        string records = $"First Name: {SaveFirstName}\nLast Name: {SaveLastName}\nAge: {SaveAge}\nEmail: {SaveEmail}\nPhone Number: {SavePhoneNumber}\nAddress: {SaveAddress}\nCity: {SaveCity}\nState: {SaveState}\nPost Code: {SavePostCode}";
        Console.WriteLine(records);
     }
    }
}