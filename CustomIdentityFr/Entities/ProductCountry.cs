using CustomIdentityFr.CoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.Entities
{
    public  class ProductCountry :BaseEntity<int >
    {
        public int ProductId { get; set; }
        public int CountryId { get; set; }

        public  virtual  Country Country { get; set; }
        public  virtual  Product Product { get; set; }

        public virtual ICollection<AppUserProfile> AppUserProfiles { get; set; }
    }
}
