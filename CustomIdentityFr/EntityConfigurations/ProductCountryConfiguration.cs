using CustomIdentityFr.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.EntityConfigurations
{
    public  class ProductCountryConfiguration:BaseConfiguration<ProductCountry>
    {
        public override void Configure(EntityTypeBuilder<ProductCountry> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Country).WithMany(x=>x.ProductCountries).HasForeignKey(x=>x.CountryId);
            builder.HasOne(x => x.Product).WithMany(x => x.MedeInCountries).HasForeignKey(x => x.ProductId);
        }
    }
}
