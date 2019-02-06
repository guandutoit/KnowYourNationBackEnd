using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Know_Your_Nation_Speedy.Models
{
    public class Events
    {
        public int EventsId { get; set; }
        public string ProjectName { get; set;}
        public string  Description{ get; set; }
        public string Address { get; set; }
        public DateTime date { get; set; }
        public ICollection<UserEvents> userEvents { get; set; }
    }
}