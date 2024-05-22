using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.CoreEntity;

    public  class BaseEntity<TId> : IEntity
    {
        public TId Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
    }

}
