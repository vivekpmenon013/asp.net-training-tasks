using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tasks.Models;
using Tasks.Services;

namespace Tasks.ApiControllers
{
    public class StoreController : ApiController
    {
        IStoreService ss;
        public StoreController(IStoreService ss)
        {
            this.ss = ss;
        }
        public ItemModel GetItemDetails(int itemID)
        {
            ItemModel item = this.ss.GetItemDetails(itemID);
            return item;
        }
    }
}
