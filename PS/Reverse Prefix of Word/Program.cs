namespace Reverse_Prefix_of_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "abcdefd";  string ch = "d";


            string newstring = string.Empty;


        }
        public static string reverse(string word, char ch)
        {
            int index = word.IndexOf(ch);
            if (index == -1)
                return word; // If 'ch' is not found, return the original string

            char[] array = word.ToCharArray();
            Array.Reverse(array, 0, index + 1);

            return new string(array);

        }
    }
}
