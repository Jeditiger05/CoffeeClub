using System;
using System.Collections.Generic;

namespace CoffeeClubAPI.Models
{
    public partial class Booking
    {
        public int BookingNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public string Name { get; set; }
        public string Shoutee { get; set; }
        public double? AmountShouted { get; set; }
        public string Venue { get; set; }
        public int MemberId { get; set; }

        public virtual Member Member { get; set; }
    }
}
