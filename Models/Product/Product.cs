﻿namespace MegaventoryCart.Models.Product
{
    public class Product
    {
        public int ProductID { get; set; }
        public int ProductSKU { get; set; }
        public string ProductDescription { get; set; }
        public double ProductSellingPrice { get; set; }
        public double ProductPurchasePrice { get; set; }
    }
}