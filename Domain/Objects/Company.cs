using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class Company : Base
    {
        public virtual ICollection<Store> Stores { get; set; }
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
