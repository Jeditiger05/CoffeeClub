using System;
using System.Collections.Generic;

namespace CoffeeClubAPI.Models
{
    public partial class Member
    {
        public Member()
        {
            Booking = new HashSet<Booking>();
        }

        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Pending { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
