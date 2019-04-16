using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherited
{
    class ImagePost:Post
    {
        public string ImageURL { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title,string sendByUsername,string imageUrl,bool isPublic)
        {

            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageURL = imageUrl;


        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return String.Format("{0} - {1} - {2} by {3}", this.ID, this.Title, this.ImageURL,this.SendByUsername);

        }
    }
}
