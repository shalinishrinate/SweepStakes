using SweepStakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweep_Stakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant contestant = new Contestant();
            SweepStakes sweepstakes = new SweepStakes();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
            Console.ReadLine();

            
        }
    }
}
