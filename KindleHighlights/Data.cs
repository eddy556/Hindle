using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace KindleHighlights
{
    public class Data
    {       
        public void AddItem(CloudTable table)
        {
            HighlightEntity item = new HighlightEntity("title2", "author3")
            { pageNo = 1, location = 1, dateAdded = null };

            // Create the TableOperation that inserts the customer entity.
            TableOperation insertOperation = TableOperation.Insert(item);

            // Execute the insert operation.
            table.Execute(insertOperation);
        }

        public IEnumerable<HighlightEntity> GetAllItems(CloudTable table)
        {
            // Construct the query operation for all customer entities where PartitionKey="Smith".
            TableQuery<HighlightEntity> query = new TableQuery<HighlightEntity>();

            return table.ExecuteQuery(query);          

        }
    }
}