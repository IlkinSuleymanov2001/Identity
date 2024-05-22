using CustomIdentityFr.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.EntityConfigurations
{
    public  class OrderDetailConfiguration :BaseConfiguration<OrderDetail>
    {

        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new 
            { 
                OrderId = x.OrderId,
                ProductId = x.ProductId
            });

            builder.HasOne(x=>x.Order).WithMany(x=>x.OrderDetails).HasForeignKey(x=>x.OrderId);
            builder.HasOne(x=>x.Product).WithMany(x=>x.OrderDetails).HasForeignKey(x=>x.ProductId);
        }
    }
}
