using System;
using System.IO;

namespace Assessment_2_o_op
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose which files you want to test, 1,2,3");
            var number = Console.ReadLine();

            if (number == "1")
            {
                string file = File.ReadAllText("GitRepositories_1a.txt");
                string file2 = File.ReadAllText("GitRepositories_1b.txt");
            
                if (file == file2)
                {
                    Console.WriteLine("they are not different");
                }
                else
                {
                    Console.WriteLine("They are different");
                }
            }
            else if (number == "2")
            {
                string file = File.ReadAllText("GitRepositories_2a.txt");
                string file2 = File.ReadAllText("GitRepositories_2b.txt");

                if (file == file2)
                {
                    Console.WriteLine("they are not different");
                }
                else
                {
                    Console.WriteLine("They are different");
                }
            }
            else
            {
                string file = File.ReadAllText("GitRepositories_3a.txt");
                string file2 = File.ReadAllText("GitRepositories_3b.txt");

                if (file == file2)
                {
                    Console.WriteLine("they are not different");
                }
                else
                {
                    Console.WriteLine("They are different");
                }
            }

            
        }
    }
}
