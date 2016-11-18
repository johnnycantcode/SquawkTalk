using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SquawkTalk.Models
{
    public class FeedListModel
    {
        public string Site { get; set; }

        public string FeedUrl { get; set; }
        public string Category { get; set; }
        public string SearchTerm { get; set; }

        public bool Telecommute { get; set; }

        public bool Contract { get; set; }

        public List<FeedItemModel> FeedItems { get; set; }


    }
}