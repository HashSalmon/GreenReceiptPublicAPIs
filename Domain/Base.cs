using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Base
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public abstract bool PreSave();

        public abstract bool PreUpdate();

        public Action PostSave { get; set; }
        public Action PostUpdate { get; set; }

    }
}
