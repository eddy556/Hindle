using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using KindleHighlights.Models;
using Microsoft.WindowsAzure.Storage.Table.DataServices;

namespace KindleHighlights
{
    public class Data
    {       
        public void AddItem(CloudTable table)
        {
            //HighlightEntity item = new HighlightEntity("title2", "author3")
            //{ pageNo = 1, location = 1, dateAdded = null };

            //// Create the TableOperation that inserts the customer entity.
            //TableOperation insertOperation = TableOperation.Insert(item);

            //// Execute the insert operation.
            //table.Execute(insertOperation);
        }

        public IEnumerable<HighlightEntity> GetAllItems(CloudTable table)
        {
            var query = new TableQuery<HighlightEntity>();

            var results = table.ExecuteQuery<HighlightEntity>(query);

            Nullable<int> value = new Nullable<int>(2);
            Nullable<Nullable<int>> value1 = new Nullable<Nullable<int>>

            return results.ToList<HighlightEntity>();         



        }
    }
}