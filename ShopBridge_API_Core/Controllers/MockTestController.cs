using Microsoft.AspNetCore.Mvc;
using ShopBridge_API_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge_API_Core.Controllers
{
    public class MockTestController : ControllerBase
    {

        private readonly List<InventoryItems> _inventorylist;
        public MockTestController()
        {
            _inventorylist = new List<InventoryItems>()
            {
                new InventoryItems() { Item_Id = 1,
                    Item_Name = "Car", Item_Description="benz car", Item_Price = "100" },
                new InventoryItems() { Item_Id = 2,
                    Item_Name = "Bus", Item_Description="benz Bus", Item_Price = "200" },

            };
        }



        [HttpGet] // For Getting All Items
        public IEnumerable<InventoryItems> Get()
        {
            try
            {

                return _inventorylist;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("{ID}")] // For Getting Specific Inventory Item
        public InventoryItems Get(int Id)
        {
            try
            {
                return _inventorylist.Where(a => a.Item_Id == Convert.ToInt32(Id))
            .FirstOrDefault();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPost]  // For Posting Inventory Item
        public bool Post(InventoryItems Data)
        {
            try
            {

                _inventorylist.Add(Data);
                return true;

            }
            catch (Exception ex)
            {

                throw;
            }

        }
        [HttpDelete]
        [Route("{ID}")]  // For Deleting Inventory Item
        public bool Delete(int ID)
        {
            try
            {
                var existing = _inventorylist.First(a => a.Item_Id == ID);
                _inventorylist.Remove(existing);
                return true;

            }
            catch (Exception ex)
            {

                throw;
            }

        }



    }
}
