using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuyService.Models
{
    public class VendorDto
    {
        public int vendorId { get; set; }
        public string vendorName { get; set; }
        public int rating { get; set; }
        public double deliveryCharge { get; set; }
    }
}
