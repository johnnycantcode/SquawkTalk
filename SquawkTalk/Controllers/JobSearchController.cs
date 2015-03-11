﻿using SD.LLBLGen.Pro.ORMSupportClasses;
using SquawkTalk.Datalayer.CollectionClasses;
using SquawkTalk.Datalayer.EntityClasses;
using SquawkTalk.Datalayer.HelperClasses;
using SquawkTalk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public JsonResult SearchResults(string[] feeds, string[] categories, string searchterm, bool telecommute = false, bool contract = false)
        {

            int ii = 0;
            //foreach (var guid in feeds)
            //{
            //    //var feed = new FeedEntity(Guid.Parse(guid));
            //    //var model = new SearchModel();
            //    //model.FeedUrl = feed.FeedUrl;
            //    //model.Category = category;
            //    //model.SearchTerm = searchterm;
            //    //model.Telecommute = telecommute;
            //    //model.Contract = contract;


            //    //var addOn = string.Empty;
            //    //if (telecommute)
            //    //    addOn = "is_telecommuting=1";
            //    //else
            //    //    addOn = "is_telecommuting=0";

            //    //if (contract)
            //    //    addOn += "&is_contract=1";

            //    //var url = string.Format("{0}search/{1}?{2}&query={3}&format=rss", feed.FeedUrl, category, addOn,
            //    //    searchterm);
            //    //model.FeedItems = CraigslistReader.GetFeedItems(url);

            //    ////Get all the IDs of responses sent to this feed. That way we don't send duplicates
            //    //var responses = new ResponseCollection();
            //    //var filter = new PredicateExpression();
            //    //filter.Add(ResponseFields.FeedGuid == feed.Guid);
            //    //responses.GetMulti(filter);
            //    //model.FeedResponsesByEmail = new List<string>();
            //    //model.FeedResponsesByID = new List<string>();
            //    //foreach (var r in responses)
            //    //{
            //    //    if (!model.FeedResponsesByEmail.Contains(r.ToEmail))
            //    //        model.FeedResponsesByEmail.Add(r.ToEmail);

            //    //    if (!model.FeedResponsesByID.Contains(r.Id))
            //    //        model.FeedResponsesByID.Add(r.Id);
            //    //}
            //}
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
    }
}