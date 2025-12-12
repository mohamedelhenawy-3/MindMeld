using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock
{
    public class Wallet
    {
        private readonly object bitcoinlock = new object();
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bitcoins { get; set; }



        public Wallet(string n, int b, int id)
        {
            Name = n;
            Bitcoins = b;
            Id = id;
        }
        public void Depit(int amount)
        {

            lock (bitcoinlock)
            {

                if (amount < Bitcoins)
                {
                    Thread.Sleep(1000);
                    Bitcoins -= amount;

                }
            }


        }

        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;
        }



        public override string ToString()
        {
            return $" the Name {Name} and Amount of BitConi {Bitcoins}";
        }
    }
}
