using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class Receipt : Base
    {
        public long StoreId { get; set; }
        public Store Store { get; set; }

        public string Barcode { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal Tax { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public CardType CardType { get; set; }
        public string LastFourCardNumber { get; set; }

        public DateTime ReturnDate { get; set; }

        public string CashierId { get; set; }

        public string MiscMessage { get; set; }

        public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }

        public Receipt()
        {
        }

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
