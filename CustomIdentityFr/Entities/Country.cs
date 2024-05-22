using CustomIdentityFr.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.Entities
{
    public  class Country:BaseEntity<int>
    {
        public string? CountryName  { get; set; }
        public string? CountryCode { get; set; }

        public virtual ICollection<ProductCountry> ProductCountries { get; set; }
        public virtual ICollection<AppUserProfile> AppUserProfiles { get; set; }
    }
}
