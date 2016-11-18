using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace SquawkTalk.Models
{
    public class FeedItemModel
    {
        public FeedItemModel()
        {
            //empty constructor
        }

        public FeedItemModel(string id, string sitename, string title, string url, string desc, string siteurl, DateTime issued)
        {
            this.Id = id;
            this.SiteName = sitename;
            this.Title = title;
            this.Url = url;
            this.Description = desc;
            this.SiteUrl = siteurl;
            this.Issued = issued;
        }

        public string SiteName { get; set; }

        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        public string SiteUrl { get; set; }

        public string Id { get; set; }

        public DateTime Issued { get; set; }

        public string IssuedDateString
        {
            get
            {
                double hours = (DateTime.Now - Issued).TotalHours;
                if(hours > 24)
                    return string.Format("{0} days ago", Math.Round(hours/24, 0).ToString());
                else
                    return string.Format("{0} hours ago", Math.Round(hours, 0).ToString());
            }
        }

        public string GetReplyToUrl()
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream data = client.OpenRead(this.Url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            //instantiate with this pattern 
            Regex emailRegex = new Regex("<a (.*\\s)?href=\"?'?(.*?)\"?'?(\\s.*)?>");
            //find items that matches with our pattern
            MatchCollection matches = emailRegex.Matches(s);
            foreach (Match m in matches)
            {
                if (m.Value.Substring(7, 9) == "replylink")
                {
                    int start = m.Value.IndexOf("href") + 7;
                    int end = m.Value.IndexOf(">");
                    var link = m.Value.Substring(start, end - start - 1);
                    return string.Format("{0}{1}", this.SiteUrl, link);
                }

            }

            return string.Empty;

        }
    }
}
