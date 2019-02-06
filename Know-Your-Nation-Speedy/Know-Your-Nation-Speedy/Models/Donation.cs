using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Know_Your_Nation_Speedy.Models
{
    public class Donation
    {
        public int DonationId { get; set; }
        public string Organization { get; set; }
        public double AmountDonated { get; set; }
        public DateTime Date { get; set; }
        public User user { get; set; }
    }
}
