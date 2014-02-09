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
        string title {get; set;}
        string author {get; set;}
        int pageNumber {get; set;}
        int locationStart {get; set;}
        int locationEnd {get; set;}
        DateTime highlightedDate {get; set;}
        string hightlightedText {get; set;}
        
    }
}