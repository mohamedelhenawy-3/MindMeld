namespace Spiral_Matrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[,] mat = {{1, 2, 3, 4},
                      {5, 6, 7, 8},
                      {9, 10, 11, 12},
                      {13, 14, 15, 16}};

            List<int> res = SpiralMatrix(mat);
            Console.WriteLine(string.Join(" ", res));
        }
        public static List<int> SpiralMatrix(int[,] Matrix)
        {
            int rowNums = Matrix.GetLength(0);
            int colNums = Matrix.GetLength(1);
            List<int> result = new List<int>();

            int left = 0, top = 0, buttom = rowNums - 1, right = colNums - 1;

            while (top <= buttom && left <= right)
            {
                //print top => left to right 
                for (int i = left; i <= right; i++)
                {
                    result.Add(Matrix[top, i]);
                }
                top++;

                //print top to buttom
                for (int i = top; i <= buttom; i++)
                {
                    result.Add(Matrix[i, right]);
                }
                right--;


                // Print bottom row from right to left (if exists)
                if (top <= buttom)
                {
                    for (int i = right; i >= left; --i)
                    {
                        result.Add(Matrix[buttom, i]);
                    }
                    buttom--;
                }

                // Print left column from bottom to top (if exists)
                if (left <= right)
                {
                    for (int i = buttom; i >= top; --i)
                    {
                        result.Add(Matrix[i, left]);
                    }
                    left++;
                }

            }
            return result;
        }
    }


   
}
