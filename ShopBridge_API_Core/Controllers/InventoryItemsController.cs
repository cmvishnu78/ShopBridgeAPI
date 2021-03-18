using Dapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ShopBridge_API_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge_API_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class InventoryItemsController : ControllerBase
    {
        //Api Controller for Inventory items Action
        private IConfiguration Configuration;
        DapperCrud Dap;
        public InventoryItemsController(IConfiguration config)
        {
            Configuration = config;
            string connectionstring = config.GetConnectionString("ShopBridgeconnection");
            Dap = new DapperCrud(connectionstring);
        }

        [HttpGet] // For Getting All Items
        public IEnumerable<InventoryItems> Get()
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@ItemID", 0);
                param.Add("@Mode", "AllItems");
                var Result = Dap.ExecuteSPAsync<InventoryItems>("Fetchinventoryitems_SP", param);
                return Result;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("{ID}")] // For Getting Specific Inventory Item
        public IEnumerable<InventoryItems> Get(int ID)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@ItemID", ID);
                param.Add("@Mode", "SpecificItems");
                var Result = Dap.ExecuteSPAsync<InventoryItems>("Fetchinventoryitems_SP", param);
                return Result;

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
                var param = new DynamicParameters();
                param.Add("@Item_Name", Data.Item_Name);
                param.Add("@Item_Description", Data.Item_Description);
                param.Add("@Item_Price", Data.Item_Price);
                param.Add("@ImageUrl", Data.ImageUrl);
                var Result = Dap.ExecuteSPAsync<InventoryItems>("PostInventoryItems_SP", param);
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
                var param = new DynamicParameters();
                param.Add("@ItemID", ID);
                param.Add("@Mode", "DeleteItem");
                var Result = Dap.ExecuteSPAsync<InventoryItems>("Fetchinventoryitems_SP", param);
                return true;

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
