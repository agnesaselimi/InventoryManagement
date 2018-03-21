using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorySystem
{
    struct Product
    {
        int id;
        public string ProductName;
        public string ProductCost;
        string ProductDescription;
        string ProductCategory;

        public Product(int id, string ProductName, string ProductCost, string ProductDescription, string ProductCategory)
        {
            this.id = id;
            this.ProductName = ProductName;
            this.ProductCost = ProductCost;
            this.ProductDescription = ProductDescription;
            this.ProductCategory = ProductCategory;
        }
    }
}
