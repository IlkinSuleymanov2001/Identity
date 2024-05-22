using CustomIdentityFr.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CustomIdentityFr.EntityConfigurations
{
    public  class AppUserProfileConfiguration :BaseConfiguration<AppUserProfile>
    {
        public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Country).WithMany(x => x.AppUserProfiles).HasForeignKey(x=>x.CountryId);
            builder.HasOne(x => x.AppUser).WithOne(x => x.AppUserProfile).HasForeignKey<AppUserProfile>(x => x.Id);
        }
    }
}
