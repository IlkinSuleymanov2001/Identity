using CustomIdentityFr.CoreEntity;
using CustomIdentityFr.Entities.Identities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.Entities
{
    public  class AppUserProfile :BaseEntity<int>
    {

        public int CountryId { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }

        public virtual Country Country { get; set; }
        public AppUser AppUser { get; set; }
    }
}
