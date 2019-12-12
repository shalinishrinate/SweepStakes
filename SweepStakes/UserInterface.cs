using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweep_Stakes
{
    class UserInterface
    {
        public static string getUserFirstName()
        {
            firstName=Console.WriteLine("Please enter your First Name.");
            return firstName;
        }

        public static string getUserLastName()
        {
            lastName=Console.WriteLine("Please enter your Last Name.");
            return lastName;
        }

        public static int getRegistrationNumber()
        { 
            registrationNumber = Console.WriteLine("Please enter your email address where you would liked to " +
            "be informed of the contest news");
            return getRegistrationNumber;
        }

        public static string getEmailAddress()
        {
            emailAddress = Console.WriteLine("Please enter your registration number " +
                   "that you received at the time of registration.");
            return getEmailAddress;
        }
               
        
    }
}
