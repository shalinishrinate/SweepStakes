using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweep_Stakes
{
     public class Contestant
    {
        string firstName;
        string lastName;
        public int registrationNumber;
        string emailAddress;

        public Contestant()
        {
        firstName = UserInterface.GetUserFirstName();
        lastName = UserInterface.GetUserLastName();
        emailAddress = UserInterface.GetEmailAddress();

        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }
    }
}
   
