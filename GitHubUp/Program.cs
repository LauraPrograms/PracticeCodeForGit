using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubUp
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            Console.WriteLine("Is this a file to be uploaded to Git? (y/n)");
            input = Console.ReadLine();
            input = input.ToLower();
            if (input == "y")
            {
                Console.WriteLine("Please upload it to GitHub.");
            }
            else
            {
                Console.WriteLine("Okay, have a good day");
            }

            Console.ReadLine();
            //try adding a try catch code to improve this
        }

    }
}
