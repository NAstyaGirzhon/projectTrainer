using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
   
     public class WDoctorModel
    {
        private static int[,] ArrayfGra = new int[2, 3];
        public static int[,] getArray
        {
            get { return ArrayfGra; }
            set { ArrayfGra = value; }
        }
    }
}
