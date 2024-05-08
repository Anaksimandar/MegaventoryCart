using MegaventoryCart.Enums.Product;
using MegaventoryCart.Enums.SupplierClient;

namespace MegaventoryCart.Models
{
    public class SupplierClient
    {
        public int SupplierClientID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ShippingAddress { get; set;}
        public string Phone { get; set;}
        public SupplierClientType SupplierClientType { get;set; }
    }
}
