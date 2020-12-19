using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalClient.Models.ViewModels
{
    public class CartViewModel
    {
        public int Product_Id { get; set; }
        public int Customer_Id { get; set; }
        [Range(100000,999999,ErrorMessage ="please enter a valid zipcode")]
        public int ZipCode { get; set; }
        
        public DateTime DeliveryDate { get; set; }

    }
}
