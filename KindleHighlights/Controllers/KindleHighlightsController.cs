using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KindleHighlights.Controllers
{
    public class KindleHighlightsController : Controller
    {
        //
        // GET: /KindleHighlights/
        public ActionResult Index()
        {

            CloudTableFactory factory = new CloudTableFactory();

            Data d = new Data();
            var items = d.GetAllItems(factory.GetKindleTableReference("kindleHighlightstest"));

            ViewBag.KindleHighlights = items;

            return View();
        }
	}
}