using EcommercePortalClient.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EcommercePortalClient.Provider
{
    public interface IProductProvider
    {
        Task<HttpResponseMessage> GetProductById(int id,string token);
        Task<HttpResponseMessage> GetProductByName(string name,string token);
        Task<HttpResponseMessage> RateAProduct(ProductViewModel prod,string token);
    }
}
