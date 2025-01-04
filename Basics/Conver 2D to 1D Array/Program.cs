namespace Conver_2D_to_1D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoMatrix obj = new TwoMatrix(2, 3);
            Console.WriteLine("Enter the Elements : ");
            obj.read2DArray();
            Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
            obj.Print2D();
            obj.convert();
            Console.WriteLine("\t\t Converted 1-D Array is : ");
            obj.printoned();
            Console.ReadLine();
        }
    }
}
