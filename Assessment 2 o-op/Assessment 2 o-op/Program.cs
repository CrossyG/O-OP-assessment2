using System;
using System.IO;

namespace Assessment_2_o_op
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose which file you want to test, 1,2,3,4,5,6");
            var number = Console.ReadLine();

            Console.WriteLine("Choose which file you want to test it against, 1,2,3,4,5,6");
            var number2 = Console.ReadLine();

            string file1 = File.ReadAllText("GitRepositories_1a.txt");
            string file2 = File.ReadAllText("GitRepositories_1b.txt");
            string file3 = File.ReadAllText("GitRepositories_2a.txt");
            string file4 = File.ReadAllText("GitRepositories_2b.txt");
            string file5 = File.ReadAllText("GitRepositories_3a.txt");
            string file6 = File.ReadAllText("GitRepositories_3b.txt");

            string choice = " ";
            string choice2 = " ";

            if (number == "1")
            {
                choice = file1;
                
            }
            else if (number == "2")
            {
                choice = file2;
            }
            else if (number == "3")
            {
                choice = file3;
            }
            else if (number == "4")
            {
                choice = file4;
            }
            else if (number == "5")
            {
                choice = file5;
            }
            else
            {
                choice = file6;
            }

            if (number2 == "1")
            {
                choice2 = file1;
            }
            else if (number2 == "2")
            {
                choice2 = file2;
            }
            else if (number2 == "3")
            {
                choice2 = file3;
            }
            else if (number2 == "4")
            {
                choice2 = file4;
            }
            else if (number2 == "5")
            {
                choice2 = file5;
            }
            else 
            {
                choice2 = file6;
            }

            if (choice == choice2)
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are different");
            }
        }
    }
}
