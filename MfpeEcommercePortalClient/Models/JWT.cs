using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalClient.Models
{
    public class JWT
    {
        public string Token { get; set; }
        public int User_Id { get; set; }
    }
}
