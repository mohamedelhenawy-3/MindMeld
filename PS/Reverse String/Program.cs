namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string word = "abcdefd";
            string x = String.Empty;


            for(int i = word.Length - 1; i > 0; i--)
            {
                x += word[i];
            }


            Console.WriteLine(x);

        }
    }
}
