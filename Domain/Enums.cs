using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Flags]
    public enum UserRole
    {
        
    }

    public enum CardType
    {
        Unknown,
        Amex,
        Visa,
        Mastercard,
        Discover
    }
}
