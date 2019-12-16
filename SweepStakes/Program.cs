using SweepStakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweep_Stakes;

namespace Sweep_Stakes
{
    class Program
    {
        static void Main(string[] args)
        {   
            Contestant contestant = new Contestant();
            SweepstakesClass sweepstakesClass = new SweepstakesClass();
            sweepstakesClass.RegisterContestant(contestant);
            sweepstakesClass.PickWinner();
            sweepstakesClass.PrintContestantInfo(contestant);
            sweepstakesClass.SendMessage();

        }
    }
}
