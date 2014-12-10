using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Objects;
using Domain;

namespace DA
{
#if RELEASE

#elif ALEX
    class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            //TODO: seed data
        }
    }
#else
    class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            //TODO: seed data
            var receipts = new List<Receipt>
            {
                new Receipt {StoreId = 1, Barcode="123", PurchaseDate = new DateTime(), Tax = 1.0M, SubTotal = 1.5M, Total = 2.5M, CardType = CardType.Visa, LastFourCardNumber = "1000", ReturnDate = new DateTime(15), 
                  CashierId = "1", MiscMessage = "nil", User = new User(), Store = new Store(), ReceiptItems = new List<ReceiptItem>},
            };

            var users = new List<User>
            {

            };
 
        }
    }
#endif
}
