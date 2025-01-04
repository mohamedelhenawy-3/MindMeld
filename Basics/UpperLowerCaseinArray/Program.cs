using System.Linq;

namespace UpperLowerCaseinArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Apple", "banana", "CHERRY", "Date" };

            var uppercase = words.Where(x => x.All(char.IsUpper)).ToArray();
            var lowercase = words.Where(x => x.All(char.IsLower)).ToArray();


            Console.WriteLine("Uppercase Words: " + string.Join(", ", uppercase));
            Console.WriteLine("Lowercase Words: " + string.Join(", ", lowercase));
        }



       
    }
}
