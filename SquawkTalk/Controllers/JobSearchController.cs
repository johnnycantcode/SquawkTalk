using SD.LLBLGen.Pro.ORMSupportClasses;
using SquawkTalk.Datalayer.CollectionClasses;
using SquawkTalk.Datalayer.EntityClasses;
using SquawkTalk.Datalayer.HelperClasses;
using SquawkTalk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SquawkTalk.Controllers
{
    public class JobSearchController : Controller
    {
        // GET: JobSearch
        public ActionResult Search()
        {
            var model = new SearchModel();
            var filter = new PredicateExpression();
            filter.Add(FeedFields.PersonGuid == Common.PersonGuid);
            var sorter = new SortExpression(FeedFields.Name | SortOperator.Ascending);
            var feeds = new FeedCollection();
            feeds.GetMulti(filter, 0, sorter);

            model.Feeds = feeds.ToList();


            return View(model);
        }

        public ActionResult SearchResults(string feeds, string categories, string searchterm, bool telecommute = false, bool contract = false)
        {
            var model = new SearchResultsModel();

            var sites = feeds.Split(',');
            var cats = categories.Split(',');

            foreach (var guidString in sites)
            {
                foreach (var category in cats)
                {
                    var feed = new FeedEntity(Guid.Parse(guidString));
                    var list = new FeedListModel();
                    model.Results.Add(list);
                    list.Site = feed.Name;
                    list.FeedUrl = feed.FeedUrl;
                    list.Category = category;
                    list.SearchTerm = searchterm;
                    list.Telecommute = telecommute;
                    list.Contract = contract;


                    var addOn = string.Empty;
                    if (telecommute)
                        addOn = "is_telecommuting=1";
                    else
                        addOn = "is_telecommuting=0";

                    if (contract)
                        addOn += "&is_contract=1";

                    var url = string.Format("{0}search/{1}?{2}&query={3}&format=rss", feed.FeedUrl, category, addOn,
                        searchterm);
                    list.FeedItems = CraigslistReader.GetFeedItems(url);


                   
                    //TODO: Add code to prevent duplicate emails getting sent
                    //Get all the IDs of responses sent to this feed. That way we don't send duplicates
                    //var responses = new ResponseCollection();
                    //var filter = new PredicateExpression();
                    //filter.Add(ResponseFields.FeedGuid == feed.Guid);
                    //responses.GetMulti(filter);
                    //list.FeedResponsesByEmail = new List<string>();
                    //list.FeedResponsesByID = new List<string>();
                    //foreach (var r in responses)
                    //{
                    //    if (!model.FeedResponsesByEmail.Contains(r.ToEmail))
                    //        model.FeedResponsesByEmail.Add(r.ToEmail);

                    //    if (!model.FeedResponsesByID.Contains(r.Id))
                    //        model.FeedResponsesByID.Add(r.Id);
                    //}



                }
            }
            return View(model);
        }

        public JsonResult GetSearchResults(string guidString, string category, string searchterm, bool telecommute, bool contract)
        {
            var feed = new FeedEntity(Guid.Parse(guidString));
            var list = new FeedListModel();
            list.Site = feed.Name;
            list.FeedUrl = feed.FeedUrl;
            list.Category = category;
            list.SearchTerm = searchterm;
            list.Telecommute = telecommute;
            list.Contract = contract;


            var addOn = string.Empty;
            if (telecommute)
                addOn = "is_telecommuting=1";
            else
                addOn = "is_telecommuting=0";

            if (contract)
                addOn += "&is_contract=1";

            if (!feed.FeedUrl.EndsWith("/"))
                feed.FeedUrl += "/";
            var url = string.Format("{0}search/{1}?{2}&query={3}&format=rss", feed.FeedUrl, category, addOn,
                searchterm);
            list.FeedItems = CraigslistReader.GetFeedItems(url);

            var jss = new JavaScriptSerializer();

            string output = jss.Serialize(list.FeedItems);

            return Json(output, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetReplyToEmailAddress(string url)
        {
            var replyToLink = CraigslistReader.GetReplyToLink(url);
            var email = CraigslistReader.GetReplyToEmailAddress(replyToLink);
            if (!string.IsNullOrEmpty(email))
                return Json(new { email = email, success = true }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { email = "", success = false }, JsonRequestBehavior.AllowGet);
        }
    }
}