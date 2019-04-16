using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // blueprint
    class Human
    {
        // member vars

        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        public Human()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FIRST TIME EXEC HERE");
        }


        // construtor
        public Human(string firstName, string lastName,string eyeColor,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;

        }

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1} and {2} year olds. My eyecolor is {3}", firstName, lastName, age, eyeColor);
        }

    }
}
