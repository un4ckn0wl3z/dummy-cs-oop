using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInh
{
    class Members
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Members() { }

        public Members(string fname,string lname)
        {
            this.Firstname = fname;
            this.Lastname = lname;


        }

        protected void showMemberDetails()
        {
            Console.WriteLine("Fistname: {0}, Lastname {1}",this.Firstname,this.Lastname);
        }



    }
}
