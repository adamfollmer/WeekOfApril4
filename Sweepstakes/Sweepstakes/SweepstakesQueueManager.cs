using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queueManager = new Queue<Sweepstakes>();
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return queueManager.Dequeue();
        }
        public Sweepstakes PeekNext()
        {
            return queueManager.Peek();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queueManager.Enqueue(sweepstakes);
        }
    }
}
