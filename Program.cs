using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This lines of code will write the "Student Daily Reports" for the "Academy of Learning Career College"
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            // This line of code will write "What is your name?"
            Console.WriteLine("What is your name?");
            // This line of code will let you input your answer as a string
            string name = Console.ReadLine();
            // This line of code will write "What course are you on?"
            Console.WriteLine("What course are you on?");
            // This line of code will let you input your answer as a string
            string course = Console.ReadLine();
            // This line of code will write "What page number?"
            Console.WriteLine("What page number?");
            // This line of code will cast your answer as an integer
            int page = Convert.ToInt32(Console.ReadLine());
            // This line of code will write "Do you need any help with anything? Please answer \"true\" or \"false\"."
            Console.WriteLine("Do you need any help with anything? Please answer \"true\" or \"false\".");
            // This line of code will write your answer as "true" or "false"
            string help = Console.ReadLine();
            // This line of code will cast your answer as a boolean 
            bool helpBool = bool.Parse(help);
            // This line of code will write "Were there any positive experiences you'd like to share? Please give specifics"
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            // This line of code will write your answer as a string
            string expShare = Console.ReadLine();
            // This line of code will write "Is there any other feedback you'd like to provide? Please be specific"
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            // This line of code will write your answer as a string
            string feedback = Console.ReadLine();
            // This line of code write "How many hours did you study today?"
            Console.WriteLine("How many hours did you study today?");
            // This line of code will write your answer
            string studyHours = Console.ReadLine();
            // This line of code will cast your answer as a integer
            int studyHoursNum = Convert.ToInt32(studyHours);
            // This line of code will write the ending of the program 
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            // this line of code will display all the "Console.WriteLine" commands to be read by the user
            Console.ReadLine();

        }
    }
}
