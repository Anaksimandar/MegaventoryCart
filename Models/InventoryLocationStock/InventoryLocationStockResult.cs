namespace MegaventoryCart.Models.InventoryLocationStock
{
    public class InventoryLocationStockResult
    {
        public InventoryLocationStockResult() { 
            mvProductStockUpdateList = new List<InventoryLocationStock> ();
        }
        public List<InventoryLocationStock> mvProductStockUpdateList { get; set; }
    }
}
