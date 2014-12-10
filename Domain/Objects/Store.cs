using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class Store : Base
    {
        public long CompanyId { get; set; }
        
        public virtual Company Company { get; set; }

        public override bool PreSave()
        {
            return true;
        }

        public override bool PreUpdate()
        {
            return true;
        }
    }
}
