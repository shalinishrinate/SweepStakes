using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweep_Stakes;

namespace SweepStakes
{
    interface ISweepstakesManager
    {
        void InsertSweepstakes(SweepstakesClass sweepstakes);
        SweepstakesClass GetSweepstakes();
    }
}


