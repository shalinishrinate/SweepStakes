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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        //constructor
        public Sweepstakes(string name)
        {

        }


        // member methods (can do)
        public void RegisterContestant(Contestant contestant)
        {

        }

        public string PickWinner()
        {

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
