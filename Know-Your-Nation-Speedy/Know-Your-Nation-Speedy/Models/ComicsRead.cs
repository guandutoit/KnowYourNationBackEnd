using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Know_Your_Nation_Speedy.Models
{
    public class ComicsRead
    {
        public int ComicId { get; set; }
        public int UserId { get; set; }
        public Comic comic { get; set; }
        public User user { get; set; }
        public bool ReadStatus { get; set; }
        public int Rating { get; set; }
    }
}