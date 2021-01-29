using System;
using System.Collections.Generic;

#nullable disable

namespace Project_API.Models
{
    public partial class Booking
    {
        public Booking()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        public int ResId { get; set; }
        public string PickUpLocation { get; set; }
        public string ReturnLocation { get; set; }
        public DateTime? PickUpDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public double? Deposit { get; set; }
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
