using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conver_2D_to_1D_Array
{
    public class TwoMatrix
    {
        int r;
        int c;
        int[,] TwoDarray;
        int[] OneDarray;

        public TwoMatrix(int x, int y){
            r = x;
            c = y;
            TwoDarray = new int[r, c];
            OneDarray = new int[r * c];
        }

        public void read2DArray()
        {

            for(int i =0; i < r; i++)
            {
                for(int j=0; j < c; j++)
                {
                    Console.WriteLine("TwoDarray[{0},{1}]=", i, j);
                    TwoDarray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

        }

        public void Print2D()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0}\t", TwoDarray[i, j]);

                }
                Console.Write("\n");
            }
        }
        public void convert()
        {
            int f = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    OneDarray[f++] = TwoDarray[i, j];

                }
                Console.Write("\n");
            }
        }
        public void printoned()
        {
            for (int i = 0; i < r* c; i++)
            {
                Console.WriteLine("{0}\t", OneDarray[i]);
            }
        }





    }
}
