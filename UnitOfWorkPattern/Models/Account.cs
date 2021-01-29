using System;
using System.Collections.Generic;

#nullable disable

namespace Project_API.Models
{
    public partial class Account
    {
        public string AccountId { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public bool? Status { get; set; }
    }
}
