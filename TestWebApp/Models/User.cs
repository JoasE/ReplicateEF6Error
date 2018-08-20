using System.Collections.Generic;

namespace TestWebApp.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public virtual List<Like> Likes { get; set; }
    }
}