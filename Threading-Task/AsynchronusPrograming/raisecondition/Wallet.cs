using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raisecondition
{
    internal class Wallet
    {
        private readonly object bitcoinlock = new object();
        public string Name { get; set; }
        public int Bitcoins { get; set; }



        public Wallet(string n, int b)
        {
            Name = n;
            Bitcoins = b;
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


