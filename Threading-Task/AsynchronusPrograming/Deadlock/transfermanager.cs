using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock
{
    public class transfermanager
    {


        private Wallet From;
        private Wallet To;
        private int Amount;
        



        public transfermanager(Wallet from, Wallet to, int amount)
        {
            From = from;
            To = to;
            Amount = amount;

        }


        public void Transfer()
        {
            var lock1 = From.Id < To.Id ? From : To;
            var lock2 = From.Id < To.Id ? To : From;

            Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock {lock1.Name}");

            lock (lock1)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} locked {lock1.Name}");

                Thread.Sleep(500);

                Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock {lock2.Name}");

                lock (lock2)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} locked {lock2.Name}");

                    From.Depit(Amount);
                    To.Credit(Amount);

                    Console.WriteLine($"{Thread.CurrentThread.Name} completed transfer");
                }
            }
        }
    }
}
