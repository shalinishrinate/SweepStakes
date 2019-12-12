using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweep_Stakes
{
    class SweepStakes
    {
        Dictionary<int, Contestant> sweepStakesContestants = new Dictionary<int, Contestant>();
        string name;

        public SweepStakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            
            contestant.registrationNumber = sweepStakesContestants.Count + 1;

            sweepStakesContestants.Add(contestant.registrationNumber,contestant);
        }

        public string PickWinner()
        {
            //Random random = new Random();
            //return random.Next(min, max);
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

        //Sweepstakes(string name)
        //void RegisterContestant(Contestant contestant)
        //string PickWinner()
        //void PrintContestantInfo(Contestant contestant)

    }
}
