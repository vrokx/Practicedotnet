using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SampleSellerBuyer.Models
{
    public class ProductDBContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
    }
}