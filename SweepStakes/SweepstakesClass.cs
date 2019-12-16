using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using Sweep_Stakes;



namespace Sweep_Stakes
{
    public class SweepstakesClass
    {
        public string name;
       
        Contestant contestantWinner;

        Dictionary<int, Contestant> sweepstakesContestants;

        public SweepstakesClass()
        {

        }

        public SweepstakesClass(string name)
        {
            this.name = name;
            sweepstakesContestants = new Dictionary<int, Contestant>();
        }



        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = sweepstakesContestants.Count + 1; // the registration number is related to the count,
            sweepstakesContestants.Add(contestant.registrationNumber,contestant);
        }

        public string PickWinner()
        {
            Random random = new Random();
            int winner = random.Next(sweepstakesContestants.Count+1); // key from the dictionary
            contestantWinner = sweepstakesContestants[winner]; // find value pair to key with the index
            return contestantWinner.FirstName + " " + contestantWinner.LastName;// now we can call the first name and last name associated with it
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayWinner(contestant);
        }

        public void SendMessage()
        {
            foreach (var participant in sweepstakesContestants)
            {
                if (participant.Key.Equals(contestantWinner.registrationNumber))
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("MarketingFirmAtSweepstakes"));
                    message.To.Add(new MailboxAddress(contestantWinner.FirstName + " " + contestantWinner.LastName, contestantWinner.EmailAddress));
                    message.Subject = "You are the WINNER!";

                    message.Body = new TextPart("plain")
                    {
                        Text = @"contestWinner, you won the sweepstake!"
                    };
                }

                else
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("MarketingFirmAtSweepstakes"));
                    message.To.Add(new MailboxAddress(participant.Value.FirstName + " " + participant.Value.LastName, participant.Value.EmailAddress));
                    message.Subject = "Sweepstakes";

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Unfortunately, you did not win this contest. Thanks for taking part in it."
                    };

                }

            }
        }
            
    }
}
