using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Know_Your_Nation_Speedy.Models
{
    public class AnimationsWatched
    {
        public int AnimationId { get; set; }
        public int UserId { get; set; }
        public  Animation animation{ get; set; }
        public  User user { get; set; }
        public bool WatchedStatus { get; set; }
        public int Rating { get; set; }
    }
}