using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweep_Stakes
{
    public class SweepstakesClass
    {
        Dictionary<int, Contestant> sweepstakesContestants;

        public SweepstakesClass()
        {
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
            int winner = random.Next(sweepstakesContestants.Count); // key from the dictionary
            Contestant contestantWinner = sweepstakesContestants[winner]; // find value pair to key with the index
            return contestantWinner.FirstName + " " + contestantWinner.LastName;// now we can call the first name and last name associated with it
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            string winnerInfo = contestant.FirstName + "\n" +
                                contestant.LastName + "\n" +
                                contestant.EmailAddress + "\n";

            Console.WriteLine(winnerInfo);
            Console.ReadLine();
        }

       

    }
}
