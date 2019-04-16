using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polym
{
    class Audi:Car
    {

        private string brand = "Audi";

        public string Model { get; set; }


        public Audi(int hp, string color, string model) : base(hp, color)
        {

            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand {2} -  HP : {0} Color: {1}", HP, Color, brand);
        }

        public override void Repaire()
        {
            Console.WriteLine("Audi - {0} was repaired", Model);
        }


    }
}
