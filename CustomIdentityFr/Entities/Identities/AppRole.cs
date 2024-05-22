using CustomIdentityFr.CoreEntity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.Entities.Identities
{
    public  class AppRole: IdentityRole<int>,IEntity
    {

        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}
