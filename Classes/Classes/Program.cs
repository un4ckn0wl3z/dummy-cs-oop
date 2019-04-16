using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance of Human
            Human anuwat = new Human("Anuwat","Khongchuai","black",24);

            Console.ForegroundColor = ConsoleColor.Cyan;

            anuwat.IntroduceMyself();


            Human pansa = new Human("Pansa", "Jitbunjong","blue",25);
            Console.ForegroundColor = ConsoleColor.Green;

            pansa.IntroduceMyself();


            Human basicHuman = new Human();


            Console.ReadKey();



        }
    }
}
