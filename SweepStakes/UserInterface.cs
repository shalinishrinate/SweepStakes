using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweep_Stakes
{
    public class UserInterface
    {

        public static string GetUserFirstName()
        {
            Console.WriteLine("Please enter your First Name.");
            return Console.ReadLine().ToLower();
        }

        public static string GetUserLastName()
        {
            Console.WriteLine("Please enter your Last Name.");
            return Console.ReadLine().ToLower();
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("Please enter your email address where you would liked to " +
            "be informed of the contest news");
            return Console.ReadLine().ToLower();
        }

        public static string DisplayWinner(Contestant contestant) 
        { Console.WriteLine("Firstname: " + contestant.FirstName + "\n" +
            "Lastname: " + contestant.LastName + "\n" +
            "Email address: " + contestant.EmailAddress + "\n" + 
            "Registration Number: " + contestant.registrationNumber); 

            return Console.ReadLine(); 
        }

        public static string QueueOrStackManager()
        {
            string queueOrStack;
            Console.WriteLine("Where would you like to store the Sweepstakes. Enter 1 for Queue or 2 for Stack");
            return queueOrStack = Console.ReadLine();
           
        }

        public static string GetSweepstakeName()
        {
            Console.WriteLine("Enter name of the sweepstake");
            return Console.ReadLine();
        }
    }
}