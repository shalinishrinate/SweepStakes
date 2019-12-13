using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweep_Stakes;

namespace SweepStakes
{   //A stack stores elements in the form of last in, first out. LIFO
    //This means that the elements the item that is inserted at 
    //the end will be retrieved first. The term used for adding 
    //item into stack is called pushing while retrieving item is called popping.
    public class SweepstakesStackManager : ISweepstakesManager
    {
        
        Stack<SweepstakesClass>stackSweepstakes = new Stack<SweepstakesClass> ();
       
        public SweepstakesClass GetSweepstakes()
        {
             return stackSweepstakes.Pop();
        }
        public void InsertSweepstakes(SweepstakesClass sweepstakes)
        {
            stackSweepstakes.Push(sweepstakes);
        }
    }
}