using System.ComponentModel;

namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cal x = new Cal();
            Cal.addnum adddelegate = new Cal.addnum(x.sum);
            adddelegate(10, 20);
        }
    }

    public class Cal
    {

        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);



        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }
    }
}
