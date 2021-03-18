using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge_API_Core.Models
{
    public class InventoryItems
    {
        public int Item_Id { get; set; }
        public string Item_Name { get; set; }
        public string Item_Description { get; set; }
        public string Item_Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
