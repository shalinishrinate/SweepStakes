using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweep_Stakes
{
    public class UserInterface
    {
        public int counter;
        public int registrationNum;
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

        

    }
}
