using HtmlAgilityPack;
using SquawkTalk.Datalayer.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace SquawkTalk.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ScanFeeds()
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load("http://www.craigslist.org/about/sites");
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                if (!link.OuterHtml.Contains("about") && link.OuterHtml.Contains("craigslist.org"))
                {
                    var href = "http:" + link.GetAttributeValue("href", string.Empty);
                    var name = link.InnerText;

                    try
                    {
                        var newFeed = new FeedEntity();
                        newFeed.Guid = Guid.NewGuid();
                        newFeed.PersonGuid = Guid.Parse("fa406ba9-b63d-4492-bb02-ba6bc5c0fbd8");

                        newFeed.Name = name;
                        newFeed.FeedUrl = href;
                        newFeed.Save();
                    }
                    catch(ApplicationException ex)
                    {
                        //this feed already exist is mostly the cause
                    }
                }
            }

            return View();
        }
    }
}