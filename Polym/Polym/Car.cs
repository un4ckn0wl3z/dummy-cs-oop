using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polym
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp,string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP : {0} Color: {1}",HP,Color);
        }

        public virtual void Repaire()
        {
            Console.WriteLine("Car was repaired");
        }

    }
}
