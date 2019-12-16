using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweep_Stakes;

namespace SweepStakes
{
    class ManagerFactory
    {
        public static ISweepstakesManager ChooseManager(string choice)
        {
            choice = UserInterface.QueueOrStackManager();
            switch (choice)
            {
                case "1":
                    return new SweepstakesQueueManager();
                    
                case "2":
                    return new SweepstakesStackManager();

                default:
                    throw new ApplicationException("Not a valid Manager choice");

            }
        }
    }
}
