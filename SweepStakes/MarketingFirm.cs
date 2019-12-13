using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweep_Stakes;

namespace SweepStakes
{
    class MarketingFirm 
    {
        //SweepstakesQueueManager manager = new SweepstakesQueueManager();
        //SweepstakesStackManager manager = new SweepstakesStackManager();
        // so instead of going back and forth depending on which method, 
        //queue or stack is chosen, and having to make a lot of changes everytime, 
        //dependency injection should be chosen.

        ISweepstakesManager manager; // creating a variable of a manager

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;  
        }
    }
}
