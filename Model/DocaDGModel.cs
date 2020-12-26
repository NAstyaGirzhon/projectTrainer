using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocaDGModel
    {
        public static int[,] ArrayfGra = new int[2, 3];
        public static int[,] getArray
        {
            get { return ArrayfGra; }
            set { ArrayfGra = value; }
        }
        public static int[] getArr{get; set;}
        public static int GetI { get; set; }
         
    }
}
