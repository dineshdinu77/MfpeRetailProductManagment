﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalClient.Models
{
    public class CartDbContext :DbContext
    {
        public CartDbContext(DbContextOptions<CartDbContext> options) : base(options)
        {
        }
        public virtual DbSet<CartDto> Cart { get; set; }
    }
}
