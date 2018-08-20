using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    public class Comment : Likable
    {
        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public string Content { get; set; }
    }
}