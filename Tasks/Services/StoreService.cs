using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tasks.Models;

namespace Tasks.Services
{
    public interface IStoreService
    {
        List<ItemModel> GetStoreItems();
        ItemModel GetItemDetails(int itemID);
    }
    public class StoreService : IStoreService
    {
        public List<ItemModel> GetStoreItems()
        {
            List<ItemModel> storeItems = new List<ItemModel>
            {
                new ItemModel { ID = 1, Name = "Car", Image = "/images/car.png", Price = 30 },
                new ItemModel { ID = 2, Name = "Bike", Image = "/images/bike.png", Price = 40 },
                new ItemModel { ID = 3, Name = "Bus", Image = "/images/bus.png", Price = 50 },
            };
            return storeItems; ;
        }

        public ItemModel GetItemDetails(int itemID)
        {
            ItemModel item = GetStoreItems().Find(temp => temp.ID == itemID);
            return item;
        }
    }
}