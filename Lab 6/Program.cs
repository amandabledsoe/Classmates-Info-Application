using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lists of things
            //Student Names
            List<string> students = new List<string>() { "Amanda", "Vibha", "Christina", "Tomas", "Josh", "Michael","Kyle", "Jake", "Nathan", "Roy",
                "DeShawn", "Chris", "Lucas", "Kendall", "Jesse", "James", "Andres"};

            //hometowns
            List<string> hometowns = new List<string>() { "Roseville", "Vassar", "Clarkston", "Tawas", "Jackson", "Macomb", "Keego Harbor", "Jerome",
                "New Baltimore", "Richmond", "Dearborn", "Cadillac", "Ludington", "Kalamazoo", "Jefferson", "Jasper", "Auburn Hills"};

            //Favorite Foods
            List<string> favFoods = new List<string>() { "Cheeseburger Pie", "Veal", "Chips", "T-Bone Steaks", "Junk Food", "Mangos", "Kiwi Fruit",
                "Jello", "Nachos", "Ritz Crackers", "Doughnuts", "Cheese", "Lentils", "Kidney Beans", "Jolly Ranchers", "Jalapenos", "Apples"};
            #endregion
            Console.WriteLine("Welcome to our application about the C#.NET Bootcamp Classmates of April 2020!");
            Console.WriteLine("");

            bool runningProgram = true;
            while (runningProgram)
            {
                DisplayMenuOptions();
                Console.WriteLine("What would you like to do? Enter your option number below:");
                string input = Console.ReadLine();
                int confirmedNum;
                bool isANum = int.TryParse(input, out confirmedNum);
                if (isANum && confirmedNum <= 0 || isANum && confirmedNum > 5)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("I'm sorry, that number is either too high or too low. Please enter 1 through 5.");
                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.Black;
                    continue;
                }
                if (isANum)
                {
                    switch (confirmedNum)
                    {
                        case 1:
                            ProgramOverview();
                            continue;
                        case 2:
                            PrintAllStudentNames(students);
                            continue;
                        case 3:
                            DisplayHometown(hometowns, students);
                            continue;
                        case 4:
                            DisplayFavFood(favFoods, students);
                            continue;
                        case 5:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry, I didn't recognize that number. Please try again.");
                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.Black;
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("Thank you for checking out this classmates application!");
                Console.WriteLine("Have a great day!");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);
            }
        }
        public static void DisplayFavFood(List<string> favFoods, List<string> students)
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Enter the name of the student you wish to learn the Favorite Food of:");
                string answer = Console.ReadLine();
                int studentIndex = students.IndexOf(answer);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("");
                Console.WriteLine($"{answer}'s student number is {students.IndexOf(answer) + 1} and their favorite food is {favFoods[studentIndex]}.");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("I'm sorry, either no one by that name exists in our class or that's not a name. Please try again.");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public static void DisplayHometown(List<string> hometowns, List<string> students)
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Enter the name of the student you wish to learn the Hometown of:");
                string answer = Console.ReadLine();
                int studentIndex = students.IndexOf(answer);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("");
                Console.WriteLine($"{answer}'s student number is {students.IndexOf(answer) + 1} and their hometown is {hometowns[studentIndex]}.");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("I'm sorry, either no one by that name exists in our class or that's not a name. Please try again.");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public static void DisplayMenuOptions()
        {
            Console.WriteLine("You have several action options to select from");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("===============================================");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Option 1: Get Overview of this Program");
            Console.WriteLine("Option 2: Print the 2020 C#.NET Class Roster");
            Console.WriteLine("Option 3: Discover a Student's Hometown");
            Console.WriteLine("Option 4: Discover a Student's Favorite Food");
            Console.WriteLine("Option 5: Exit This Program");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("===============================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
        }

        public static void PrintAllStudentNames(List<string> students)
        {
            Console.WriteLine("");
            Console.WriteLine("Now Printing Class Roster ...");
            Thread.Sleep(2000);
            Console.WriteLine("");
            foreach(var student in students)
            {
                Console.WriteLine($"{students.IndexOf(student)+1}: {student}");
            }
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Printing of Class Roster Complete!");
            Thread.Sleep(2000);
            Console.WriteLine("");
        }

        public static void ProgramOverview()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("");
            Console.WriteLine("--Program Overview--");
            Console.WriteLine("This program will recognize valid user inputs when the user (that's you!) requests information about " +
                "the 17 total students in the C#.NET boot camp class of 2020, such as their favorite food and hometown. If valid, it will then display " + 
                "the information associated with that classmate. Otherwise, it will provide an error message about the mishap. Enjoy!");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
