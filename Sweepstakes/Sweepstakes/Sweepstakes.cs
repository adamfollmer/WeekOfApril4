using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        string name;
        Dictionary<Contestant, int> entryPool = new Dictionary<Contestant, int>();
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
        public void RegisterContestant(Contestant contestant)
        {
            if (CheckIfEntered(contestant) == false)
            {
                entryPool.Add(contestant, GetRandomNumber(100000, 999999));
            }
        }
        public bool CheckIfEntered(Contestant contestant)
        {
            if (entryPool.ContainsKey(contestant))
            {
                Console.WriteLine("I'm sorry, {0}, you've already registered for this contest", contestant.Name);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetRandomNumber(int low, int high)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int number = random.Next(low, high);
            if (entryPool.ContainsValue(number))
            {
                return GetRandomNumber(low, high);
            }
            return number;
        }
        public string PickWinner()
        {
            int entryPoolLength = entryPool.Count;
            int randomNumber = GetRandomNumber(0, entryPoolLength);
            KeyValuePair<Contestant, int> winner = entryPool.ElementAt(randomNumber);
            return winner.Key.Name;
        }
        public void PrintContestantInfo (Contestant contestant)
        {
            Console.Write("Contestant name: {0}\nContestant Address: {1}\nContestant Phone: ", 
                contestant.Name, contestant.Address, contestant.Phone);
        }
    }
}
