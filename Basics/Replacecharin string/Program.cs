namespace Replacecharin_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "mohamed , reda";
            char newchar = 'o';
            string replacementstring="xyxxx";


            string updatedtext = text.Replace(newchar.ToString(), replacementstring);


            Console.WriteLine(updatedtext);

        }
    }
}
