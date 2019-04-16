using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListz
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(23);
            myArrayList.Add(128);
            myArrayList.Add(34);
            myArrayList.Add(91);

            myArrayList.Remove(128);

            myArrayList.RemoveAt(0);

            Console.WriteLine("Array size: " + myArrayList.Count);
          
            foreach (Object obj in myArrayList)
            {

        
                Console.WriteLine("Elems :{0} ",obj);
            }




            Console.ReadLine();







        }
    }
}
