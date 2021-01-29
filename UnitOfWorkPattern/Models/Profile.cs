using System;
using System.Collections.Generic;

#nullable disable

namespace Project_API.Models
{
    public partial class Profile
    {
        public int ProfileId { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string IdentityCard { get; set; }
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
