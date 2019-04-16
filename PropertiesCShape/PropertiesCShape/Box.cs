using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesCShape
{
    class Box
    {


        public int Len { get; set; }
        public int Hei { get; set; }
        public int Wid { get; set; }
        public int Vol { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", Len, Hei, Wid, Vol = Wid * Hei * Len);
        }

    }
}
