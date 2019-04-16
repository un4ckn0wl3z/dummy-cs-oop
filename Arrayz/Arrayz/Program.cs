using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 30;
            grades[3] = 25;
            grades[4] = 40;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0}", grades[0]);
            Console.ReadKey();

            int[] gradeOfStudent = { 20,10,23,42,32,31};
            int[] gradeOfStudentInit = new int[]{ 20, 10, 23, 42, 32, 31 };

            Console.WriteLine("len of gradeOfStudentInit : {0}", gradeOfStudentInit.Length);
            Console.ReadKey();




        }
    }
}
