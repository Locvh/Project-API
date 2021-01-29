using System;
using System.Collections.Generic;

#nullable disable

namespace Project_API.Models
{
    public partial class BookingDetail
    {
        public int ResId { get; set; }
        public int CarId { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? FormDate { get; set; }

        public virtual Car Car { get; set; }
        public virtual Booking Res { get; set; }
    }
}
