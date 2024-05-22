using CustomIdentityFr.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.EntityConfigurations
{
    public  class ProductConfigguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.Category).WithMany(x => x.Products).HasForeignKey(x=>x.CategoryId);
        
        }   
    }
}
