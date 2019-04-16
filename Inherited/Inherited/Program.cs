using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherited
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes",true,"Anuwat");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my book","Anuwat","https://www.google.com/anz",true);
            Console.WriteLine(imagePost1.ToString());

            Console.ReadKey();



        }
    }
}
