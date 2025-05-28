using System;

public class StudentInfoGWA_Calculator
{
    public static void Main(string[] args)
    {
        // Declare variables for personal information
        string lastName, firstName, middleName;
        string houseNumber, streetName, subvill, brgy, city, province;
        string contactNumber, email;

        // ===== Part 1: Collect Personal Information =====
        Console.WriteLine("Last Name: ");
        lastName = Console.ReadLine();

        Console.WriteLine("First Name: ");
        firstName = Console.ReadLine();

        Console.WriteLine("Middle Name: ");
        middleName = Console.ReadLine();

        Console.WriteLine("House Number: ");
        houseNumber = Console.ReadLine();

        Console.WriteLine("Street Name: ");
        streetName = Console.ReadLine();

        Console.WriteLine("Subdivision/Village: ");
        subvill = Console.ReadLine();

        Console.WriteLine("Barangay: ");
        brgy = Console.ReadLine();

        Console.WriteLine("City/Municipality: ");
        city = Console.ReadLine();

        Console.WriteLine("Province: ");
        province = Console.ReadLine();

        Console.WriteLine("Contact Number: ");
        contactNumber = Console.ReadLine();

        Console.WriteLine("Email Address: ");
        email = Console.ReadLine();

        // ===== Display Collected Personal Info =====
        Console.WriteLine("Full Name: " + lastName + ", " + firstName + " " + middleName);
        Console.WriteLine("Address: " + houseNumber + ", " + streetName + " Street, " + subvill + ", Barangay " + brgy + ", " + city + ", " + province);
        Console.WriteLine("Contact Number: " + contactNumber);
        Console.WriteLine("Email Address: " + email);


        // ===== Part 2: Collect Subject Info and Grades =====

        // Declare subject and grade variables
        string subjectCode1, subjectCode2, subjectCode3, subjectCode4, subjectCode5;
        string subjectName1, subjectName2, subjectName3, subjectName4, subjectName5;
        double GWA, grade1, grade2, grade3, grade4, grade5;

        // Subject 1 input
        Console.WriteLine("Subject Code 1: ");
        subjectCode1 = Console.ReadLine();
        Console.WriteLine("Subject Name: ");
        subjectName1 = Console.ReadLine();
        Console.WriteLine("Grade: ");
        grade1 = Convert.ToDouble(Console.ReadLine());

        // Subject 2 input
        Console.WriteLine("Subject Code 2: ");
        subjectCode2 = Console.ReadLine();
        Console.WriteLine("Subject Name: ");
        subjectName2 = Console.ReadLine();
        Console.WriteLine("Grade: ");
        grade2 = Convert.ToDouble(Console.ReadLine());

        // Subject 3 input
        Console.WriteLine("Subject Code 3: ");
        subjectCode3 = Console.ReadLine();
        Console.WriteLine("Subject Name: ");
        subjectName3 = Console.ReadLine();
        Console.WriteLine("Grade: ");
        grade3 = Convert.ToDouble(Console.ReadLine());

        // Subject 4 input
        Console.WriteLine("Subject Code 4: ");
        subjectCode4 = Console.ReadLine();
        Console.WriteLine("Subject Name: ");
        subjectName4 = Console.ReadLine();
        Console.WriteLine("Grade: ");
        grade4 = Convert.ToDouble(Console.ReadLine());

        // Subject 5 input
        Console.WriteLine("Subject Code 5: ");
        subjectCode5 = Console.ReadLine();
        Console.WriteLine("Subject Name: ");
        subjectName5 = Console.ReadLine();
        Console.WriteLine("Grade: ");
        grade5 = Convert.ToDouble(Console.ReadLine());

        // ===== Compute and Display GWA =====
        GWA = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
        Console.WriteLine("General Weighted Average: " + GWA);
    }
}