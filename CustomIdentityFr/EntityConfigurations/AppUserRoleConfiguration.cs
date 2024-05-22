using CustomIdentityFr.Entities.Identities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.EntityConfigurations
{
    public class AppUserRoleConfiguration : BaseConfiguration<AppUserRole>
    {

        public override void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new
            {
                UserId = x.UserId,
                RoleId = x.RoleId,
            });
            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUserRoles).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.AppRole).WithMany(x => x.AppUserRoles).HasForeignKey(x => x.RoleId);

        }
    }
}
