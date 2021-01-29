using System;
using System.Collections.Generic;

#nullable disable

namespace Project_API.Models
{
    public partial class Category
    {
        public Category()
        {
            Cars = new HashSet<Car>();
        }

        public int CateId { get; set; }
        public string Colour { get; set; }
        public string Manufacture { get; set; }
        public string Model { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
