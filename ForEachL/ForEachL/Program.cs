using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachL
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10] ;

            for (int i =0;i<10;i++)
            {
                nums[i] = i;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Elems1 {0}", nums[j]);
            }


            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Elems2 {0}", nums[j]);
            }

            foreach (int n in nums)
            {
                Console.WriteLine("Elems3 {0}", n);
            }


            string[] myfriends = { "A", "S", "F", "X", "L", "O", "A", "Q", "V", "H", "G", "O", "Y", "N" };

            foreach (string m in myfriends)
            {
                Console.WriteLine("Hi, {0}", m);
            }

            Console.ReadKey();

        }
    }
}
