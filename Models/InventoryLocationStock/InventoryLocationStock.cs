namespace MegaventoryCart.Models.InventoryLocationStock
{
    public class InventoryLocationStock
    {
        public int InventoryLocationStockID { get; set; }
        public int InventoryLocationID { get; set; }
        public string ProductSKU { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductUnitCost { get; set; }

    }
}
