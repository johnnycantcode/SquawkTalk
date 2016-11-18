using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SquawkTalk.Models
{
    public class SearchResultsModel
    {
        public SearchResultsModel()
        {
            this.Results = new List<FeedListModel>();
        }
        public List<FeedListModel> Results { get; set; }
               
    }
}