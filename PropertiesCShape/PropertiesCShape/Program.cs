using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesCShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Len = 5;
            box.Hei = 3;
            box.Wid = 4;

            box.DisplayInfo();
            Console.ReadKey();
        }
    }
}
