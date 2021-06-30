using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support_Bank.Models
{
    class UserResponses
    {
        public static void AskUser(out string name, out bool statement, out bool summary)
        {
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("Would you like to a statement of all your transactions? (y/n)");
            statement = Console.ReadLine() == "y";
            Console.WriteLine("Would you like total amounts that you owe and are owed? (y/n)");
            summary = Console.ReadLine() == "y";
        }
    }
}
