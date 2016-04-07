using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stackManager = new Stack<Sweepstakes>();
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return stackManager.Pop();
        }
        public Sweepstakes PeekNext()
        {
            return stackManager.Peek();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stackManager.Push(sweepstakes);
        }
    }
}
