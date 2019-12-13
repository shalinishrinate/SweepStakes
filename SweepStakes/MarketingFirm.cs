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

        ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
            
        }
    }
}
