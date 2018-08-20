using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    public abstract class Likable
    {
        public int Id { get; set; }

        public virtual List<Like> Likes { get; set; }
    }
}