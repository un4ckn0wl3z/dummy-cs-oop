using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polym
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new BMW(150,"Red","M4"),
                new Audi(160,"Blue","A7")
            };


            foreach (var car in cars)
            {
                car.ShowDetails();
                car.Repaire();
            }

            Console.ReadKey();



        }
    }
}
