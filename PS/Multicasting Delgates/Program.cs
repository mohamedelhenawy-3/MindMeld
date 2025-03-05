using static Multicasting_Delgates.Cal;

namespace Multicasting_Delgates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cal x = new Cal();

            Cal.recDelegates rec = new Cal.recDelegates(x.area);

            rec += x.perimeter;


            rec.Invoke(12, 4);
            Console.WriteLine();

            rec.Invoke(134, 4);
            Console.WriteLine();

        }
    }
    public class Cal
    {

        public delegate void recDelegates(double height, double width);




        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        // "perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }
    }
}
