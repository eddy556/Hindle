using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Storage;

namespace KindleHighlights.Models
{
    public class HighlightEntity : Microsoft.WindowsAzure.Storage.Table.TableEntity
    {
       public string title {get; set;}
       public string author {get; set;}
       public int pageNumber {get; set;}
       public int locationStart {get; set;}
       public int locationEnd {get; set;}
       public DateTime highlightedDate {get; set;}
       public string highlightedText {get; set;}
        
    }
}