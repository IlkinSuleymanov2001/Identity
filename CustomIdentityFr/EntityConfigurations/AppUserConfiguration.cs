using CustomIdentityFr.Entities;
using CustomIdentityFr.Entities.Identities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.EntityConfigurations
{
    public  class AppUserConfiguration :BaseConfiguration<AppUser>
    {

        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);

            
            
        }
    }
}
