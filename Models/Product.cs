using MegaventoryCart.Enums.Product;

namespace MegaventoryCart.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int SKU {  get; set; }
        public string Description { get; set; }
        public double SalesPrice { get; set; }
        public double PurchasePrice { get; set; }
        public RecordAction mvRecordAction { get; set; }
    }
}
