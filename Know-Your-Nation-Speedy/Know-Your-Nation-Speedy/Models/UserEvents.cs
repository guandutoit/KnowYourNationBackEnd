using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Know_Your_Nation_Speedy.Models
{
    public class UserEvents
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
        public Events events { get; set; }
    }
}