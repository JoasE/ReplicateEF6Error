using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApp.Models
{
    public class Like
    {
        /// <summary>
        /// The id of the likable object the like is on
        /// </summary>
        [Key, Column(Order = 0)] 
        public int LikableId { get; set; }

        /// <summary>
        /// The likable object the like is on
        /// </summary>
        public virtual Likable Likable { get; set; }

        [Key, Column(Order = 1)] 
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}