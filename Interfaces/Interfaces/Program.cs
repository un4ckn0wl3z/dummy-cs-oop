using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    public interface INotifications
    {
        void showNotification();
        string getDate();

    }


    public class Notification : INotifications
    {

        private string sender;
        private string message;
        private string date;

        // def
        public Notification() {
            sender = "Admin";
            message = "Yo, what's up ?";
            date = " ";
        }


        public Notification(string sender,string message, string date)
        {
            this.sender = sender;
            this.message = message;
            this.date = date;



        }

        public string getDate()
        {
            return date;
        }

        public void showNotification()
        {
            Console.WriteLine("Message is {0} - was sent by {1} - at {2}",message,sender,date);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("Anuwat","Tsup'bro","24/24/2019");
            n1.showNotification();
            Notification n2 = new Notification("Frank", "Yep", "26/24/2019");
            n2.showNotification();

            Console.ReadKey();
        }
    }
}
