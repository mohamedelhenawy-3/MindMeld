namespace ConvertBetween_Int_and_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "124";
            int x = stringintonunmber(str);
            string z = inttostring(x);
            Console.WriteLine(x);
        }



        public static  int stringintonunmber(string str)
        {
            int sign = 1;
            int i = 0;
            int num = 0;

            if (str[0] == '-')
            {
                sign = -1;
                i = 1;
            }

            for (; i < str.Length; i++)
            {
                char c = str[i];
                if (c < '0' || c > '9')
                {
                    throw new FormatException("invALD");
                }
               
                num = num * 10 + (c - '0');
            }


            return num * sign;
        }

        public static string inttostring(int num)
        {
            if (num == 0) return "0";
            string newstr = "";
            bool IsNegative = false;


            if(num < 0)
            {
                IsNegative = true;
                num = -num; //convert it into positive;
            }

            while(num > 0)
            {
                char digit = (char)('0' + (num % 10));
                newstr = digit + newstr;
                num = num / 10;
            }
            if (IsNegative)
            {
                newstr = "-" + newstr;
            }

            return newstr;

        }
    }
}
