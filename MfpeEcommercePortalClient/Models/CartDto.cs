using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalClient.Models
{
    public class CartDto
    {
      
        [Key]
       public int cartid { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Zipcode { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
