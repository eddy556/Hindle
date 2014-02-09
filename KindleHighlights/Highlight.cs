using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KindleHighlights
{
    public class HighlightEntity : TableEntity
    {
        public HighlightEntity() { }

        public HighlightEntity(string BookTitle, string Author)
        {
            // TODO: Complete member initialization
            this.PartitionKey = BookTitle;
            this.RowKey = Author;
        }

        public int pageNo { get; set; }
        public int location { get; set; }
        public DateTime? dateAdded {get; set;}
    }
}
