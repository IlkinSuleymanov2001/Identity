using CustomIdentityFr.Entities.Identities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.EntityConfigurations
{
    public  class AppRoleConfiguration :BaseConfiguration<AppRole>
    {

        public override void Configure(EntityTypeBuilder<AppRole> builder)
        {
            base.Configure(builder);
           builder.HasKey(x => x.Id);

        }
    }
}
