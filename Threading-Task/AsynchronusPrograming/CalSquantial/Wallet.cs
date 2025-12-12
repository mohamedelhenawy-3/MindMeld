using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalSquantial
{
    internal class Wallet
    {
        public string Name { get; set; }
        public int Bitcoins { get; set; }



        public Wallet( string n, int b)
        {
            Name = n;
            Bitcoins = b;
        }
        public void Depit ( int amount)
        {
            Bitcoins -= amount;
        }

        public void Credit(int amount) { Bitcoins += amount; }




        public void transactionrandom()
        {
            int[] amounts = [10, -10, 29, -45, -34, 23, -9];

            foreach( var amountt in amounts)
            {
                int absamount = Math.Abs(amountt);
                if (amountt < 0) 
                    Depit(absamount);
                  else 
                    Credit(absamount);

                Console.WriteLine($" Thread Id :{Thread.CurrentThread.ManagedThreadId} .proccessId :{Thread.GetCurrentProcessorId()} , Amount :{amountt}");
            }
        }

        public override string ToString()
        {
            return $" the Name {Name} and Amount of BitConi {Bitcoins}";
        }
    }
}
