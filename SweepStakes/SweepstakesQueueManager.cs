using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Sweep_Stakes;

namespace SweepStakes
{

    //A Queue class stores item on the basis of first in and first out principle.
    //This means that the item which is inserted first is retrieved first while the 
    //item inserted at the end will be retrieved last.
    //Adding item into the queue is called enqueue while while retrieving item from is called dequeue.

    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<SweepstakesClass> queueSweetstakes = new Queue<SweepstakesClass>();
        public SweepstakesClass GetSweepstakes()
        {
            return queueSweetstakes.Dequeue();
        }

        public void InsertSweepstakes(SweepstakesClass sweepstakes)
        {
            queueSweetstakes.Enqueue(sweepstakes);
        }
    }
}
