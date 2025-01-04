using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class IpAddress
    {
        private int[] segmant = new int[4];

        public int this[int index]
        {
            get
            {
                return segmant[index];
            }
            set
            {
                segmant[index] = value;
            }
        }
       public IpAddress(int fp, int sp, int tp,int fop)
       {
            segmant[0] = fp;
            segmant[1] = sp;
            segmant[2] = tp;
            segmant[3] = fop;
       }

        public string add => string.Join('.', segmant);
    }
}
