using EcommercePortalClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalClient.Repository
{
    public interface ICartRepository
    {
        Task<int> AddCart(CartDto dto);
    }
}
