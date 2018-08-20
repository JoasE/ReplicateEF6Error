using System.Collections.Generic;
using Newtonsoft.Json;

namespace TestWebApp.Models
{
    public class Post : Likable
    {
        public string Title { get; set; }

        public string Content { get; set; }

        [JsonIgnore]
        public virtual List<Comment> Comments { get; set; }
    }
}