using MegaventoryCart.Enums;
using MegaventoryCart.Enums.Product;

namespace MegaventoryCart.Models
{
    public class SupplierClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ShippingAddress { get; set;}
        public string Phone { get; set;}
        public SupplierClientType SupplierClientType { get;set; }
        public RecordAction mvRecordAction { get; set; }
    }
}
