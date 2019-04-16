using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memers
{
    class Member
    {

        // private field
        private string memberName;
        private string jobTitle;
        private int salary;
        // public field
        public int age;

        public string JobTitle {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

    
        public void Introducing(bool isFriend)
        {

            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, and my job title is {1}. I'm {2} year olds",memberName,jobTitle,age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        public Member()
        {
            age = 30;
            memberName = "Lucy";
            salary = 30000;
            jobTitle = "Developers";
            Console.WriteLine("Object created.");
        }

        // finalizer
        ~Member()
        {
            // cleanup
            Console.WriteLine("Deconstruction of member obj");
            Debug.Write("Dec of member obj");
        }


    }
}
