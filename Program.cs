using System;

namespace Simple_Student_Management_APP
{
    // Add multiple students ( Use a Student class with ID, First Name, Last Name and Grade

    // I need to create a class because this is like a big folder
    public class Student
    {
        private int _studentID; // make sure to name it differently from the get set to avoid compile
        private string _FirstName;
        private string _LastName;
        private int _Grade;

        // I need to create properties for class so users can access it. It is called encapsualtion

        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public int Grade
        {
            get { return _Grade; }
            set { _Grade = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Once I am done print out welcome message, provide menu to see what user want to do 
            Console.WriteLine("Welcome, Would you like to proceed? yes/no ");
            string choice = Console.ReadLine().ToLower();

            // Condition after user choose
            if (choice != "yes")
            {
                Console.WriteLine("Thank You For Visiting, good bye ! ");
                return;
            }

            // Create an array to store the information 
            Student[] student = new Student[5];
            int currentIndex = 0;

            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student(); // Initialize each element in the array
            }

            // Asking for user input. Create a loop to get info for each student maximum 5  
            while (true)
            {
                Console.Write("Enter ID : ");
                int studentID = int.Parse(Console.ReadLine());

                Console.Write("Enter First Name : ");
                string FirstName = Console.ReadLine();

                Console.Write("Enter Last Name : ");
                string LastName = Console.ReadLine();

                Console.Write("Enter Grade : ");
                int grade = int.Parse(Console.ReadLine());

                // Store and assign student information 
                student[currentIndex].StudentID = studentID;
                student[currentIndex].FirstName = FirstName;
                student[currentIndex].LastName = LastName;
                student[currentIndex].Grade = grade;

                currentIndex++;
                if (currentIndex >= student.Length)
                {
                    break;
                }
            }

            // Ask if user want to display all the student information they just input
            Console.WriteLine("Would you like to review your input? yes/no ");
            string choice1 = Console.ReadLine().ToLower();

            if (choice1 != "yes")
            {
                Console.WriteLine("Your input has been stored, goodbye");
                return;
            }

            // Display all student
            Console.WriteLine("Here are all the students: ");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine($"ID: {student[i].StudentID}, Name: {student[i].FirstName} {student[i].LastName}, Grade: {student[i].Grade}");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            // Calculate and display the average grade 
            int totalgrade = 0;
            for (int i = 0; i < currentIndex; i++)
            {
                totalgrade += student[i].Grade;
            }

            double average = (double)totalgrade / currentIndex;
            Console.WriteLine($"Average Grade: {average:F2}");

            // Search for a student by ID 
            Console.Write("Enter a student ID to search: ");
            int searchID = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < currentIndex; i++)
            {
                if (student[i].StudentID == searchID)
                {
                    Console.WriteLine($"Found: {student[i].FirstName} {student[i].LastName}, Grade: {student[i].Grade}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student not found.");
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
