using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweep_Stakes
{
    class SweepStakes
    {
        Dictionary<int, Contestant> sweepStakesContestants;

        public SweepStakes()
        {
            sweepStakesContestants = new Dictionary<int, Contestant>();
            
        }

        public void RegisterContestant(Contestant contestant)
        {
            
            contestant.registrationNumber = sweepStakesContestants.Count + 1;

            sweepStakesContestants.Add(contestant.registrationNumber,contestant);
        }

        public string PickWinner()
        {
            Random random = new Random();
            int winner = random.Next(sweepStakesContestants.Count); // key from the dictionary
            Contestant contestantWinner = sweepStakesContestants[winner]; // find value pair to key with the index
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
