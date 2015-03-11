using SquawkTalk.Datalayer.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SquawkTalk.Models
{
    public class SearchModel
    {
        public string FeedUrl { get; set; }
        public string Category { get; set; }
        public string SearchTerm { get; set; }

        public bool Telecommute { get; set; }

        public bool Contract { get; set; }

        public List<FeedEntity> Feeds  { get; set; }

        public List<FeedItemModel> FeedItems { get; set; }

        public List<string> FeedResponsesByID { get; set; }
        public List<string> FeedResponsesByEmail { get; set; }

                
    }
}