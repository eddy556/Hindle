using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace KindleHighlights
{
    public class CloudTableFactory
    {

        private CloudStorageAccount Account()
        {
            return CloudStorageAccount.Parse(ConfigurationManager.ConnectionStrings["StorageConnection"].ConnectionString);
        }

        public CloudTable GetKindleTableReference(string tableName)
        {
            // Create the table client.
            CloudTableClient tableClient = Account().CreateCloudTableClient();

            // Create the table if it doesn't exist.
            CloudTable table = tableClient.GetTableReference(tableName);
            table.CreateIfNotExists();

            return table;
        }

        public CloudTable GetKindleTable(string tableName)
        {
            // Create the table client.
            CloudTableClient tableClient = Account().CreateCloudTableClient();

            return tableClient.GetTableReference(tableName);
        }




    }
}