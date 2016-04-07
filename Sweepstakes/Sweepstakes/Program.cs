using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
            SweepstakesStackManager stackManager = new SweepstakesStackManager();

            Sweepstakes thousandDollar = new Sweepstakes("Thousand Dollars!");
            Sweepstakes hundredDollar = new Sweepstakes("Hundred Dollars!");
            Sweepstakes millionDollar = new Sweepstakes("Million Dollars!");
            Sweepstakes billionDollar = new Sweepstakes("Billion Dollars!");

            queueManager.InsertSweepstakes(thousandDollar);
            queueManager.InsertSweepstakes(millionDollar);

            stackManager.InsertSweepstakes(billionDollar);
            stackManager.InsertSweepstakes(hundredDollar);

            Contestant one = new Contestant("Adam", "Milwaukee", "5555555");
            Contestant two = new Contestant("Marco", "Milwaukee", "5555555");
            Contestant three = new Contestant("Mike", "Milwaukee", "5555555");
            Contestant four = new Contestant("Brad", "Milwaukee", "5555555");
            Contestant five = new Contestant("Jared", "Milwaukee", "5555555");
            Contestant six = new Contestant("Jim", "Milwaukee", "5555555");
            Contestant seven = new Contestant("Andrew", "Milwaukee", "5555555");
            Contestant eight = new Contestant("Ian", "Milwaukee", "5555555");

            thousandDollar.RegisterContestant(one);
            thousandDollar.RegisterContestant(two);
            thousandDollar.RegisterContestant(three);
            thousandDollar.RegisterContestant(four);
            thousandDollar.RegisterContestant(five);
            thousandDollar.RegisterContestant(six);
            thousandDollar.RegisterContestant(seven);
            thousandDollar.RegisterContestant(eight);

            millionDollar.RegisterContestant(one);
            millionDollar.RegisterContestant(two);
            millionDollar.RegisterContestant(three);
            millionDollar.RegisterContestant(four);
            millionDollar.RegisterContestant(five);
            millionDollar.RegisterContestant(six);
            millionDollar.RegisterContestant(seven);
            millionDollar.RegisterContestant(eight);

            hundredDollar.RegisterContestant(one);
            hundredDollar.RegisterContestant(two);
            hundredDollar.RegisterContestant(three);
            hundredDollar.RegisterContestant(four);

            billionDollar.RegisterContestant(five);
            billionDollar.RegisterContestant(six);
            billionDollar.RegisterContestant(seven);
            billionDollar.RegisterContestant(eight);

            thousandDollar.RegisterContestant(eight);
            Console.WriteLine();

            Sweepstakes nextContest = queueManager.PeekNext();
            string winner1 = queueManager.GetNextSweepstakesWinner().PickWinner();
            Console.WriteLine("The winner of the {0} sweepstakes is {1}", nextContest.Name, winner1);
            Console.WriteLine();

            nextContest = stackManager.PeekNext();
            winner1 = stackManager.GetNextSweepstakesWinner().PickWinner();
            Console.WriteLine("The winner of the {0} sweepstakes is {1}", nextContest.Name, winner1);
            Console.WriteLine();

            nextContest = queueManager.PeekNext();
            winner1 = queueManager.GetNextSweepstakesWinner().PickWinner();
            Console.WriteLine("The winner of the {0} sweepstakes is {1}", nextContest.Name, winner1);
            Console.WriteLine();

            nextContest = stackManager.PeekNext();
            winner1 = stackManager.GetNextSweepstakesWinner().PickWinner();
            Console.WriteLine("The winner of the {0} sweepstakes is {1}", nextContest.Name, winner1);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
