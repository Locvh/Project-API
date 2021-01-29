using System;
using System.Collections.Generic;

#nullable disable

namespace Project_API.Models
{
    public partial class Garage
    {
        public Garage()
        {
            Cars = new HashSet<Car>();
        }

        public int GarageId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
