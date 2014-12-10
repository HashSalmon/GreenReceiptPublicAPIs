using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class ReceiptItem :Base
    {
        public string ItemName { get; set; }

        public decimal Price { get; set; }

        public virtual Receipt Receipt { get; set; } 

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
