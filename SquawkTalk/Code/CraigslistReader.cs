using SquawkTalk.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace SquawkTalk
{
    public class CraigslistReader
    {

        public static List<FeedItemModel> GetFeedItems(string feedUrl)
        {
            var xmlDoc = new XmlDocument();
            WebRequest req = HttpWebRequest.Create(feedUrl);
            using (Stream stream = req.GetResponse().GetResponseStream())
            {

                using (StreamReader oReader = new StreamReader(stream, Encoding.GetEncoding("UTF-8")))
                {
                    xmlDoc.Load(oReader);
                }
            }
            var nTable = xmlDoc.NameTable;
            var nsManager = new XmlNamespaceManager(nTable);
            nsManager.AddNamespace("rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#");
            nsManager.AddNamespace("item", "http://purl.org/rss/1.0/");
            nsManager.AddNamespace("dc", "http://purl.org/dc/elements/1.1/");

            var xmlItems = xmlDoc.DocumentElement.SelectNodes("//rdf:RDF/item:item", nsManager);

            var feedItems = new List<FeedItemModel>();
            foreach (XmlNode currentItem in xmlItems)
            {
                var title = currentItem.SelectSingleNode("item:title", nsManager).InnerText;
                var link = currentItem.SelectSingleNode("item:link", nsManager).InnerText;
                var desc = currentItem.SelectSingleNode("item:description", nsManager).InnerText;

                Uri uri = new Uri(link);
                var id = Path.GetFileName(uri.AbsolutePath).Replace(".html", "");
                var siteurl = string.Format("{0}://{1}/", uri.Scheme, uri.DnsSafeHost);
                //var id = uri.
                feedItems.Add(new FeedItemModel(id, title, link, desc, siteurl));
            }
            return feedItems;
        }

        public static string GetReplyToEmailAddress(string replyToLink)
        {
            Uri uri;
            bool result = Uri.TryCreate(replyToLink, UriKind.Absolute, out uri);
            if (!result)
                return string.Empty;

            WebClient client = new WebClient();

            // Add a user agent header in case the  
            // requested URI contains a query.

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead(replyToLink);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            //instantiate with this pattern 
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
            //find items that matches with our pattern
            MatchCollection emailMatches = emailRegex.Matches(s);
            if (emailMatches.Count > 0)
                return emailMatches[0].Value;
            else
                return string.Empty;
        }

        public static string GetReplyToLink(string url)
        {
            var uri = new Uri(url);
            var siteUrl = string.Format("{0}://{1}", uri.Scheme, uri.DnsSafeHost);
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream data = client.OpenRead(url);
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
                    if (siteUrl.GetLast(1) != "/")
                    {
                        siteUrl += "/";
                    }
                    var replyToUrl = string.Format("{0}{1}", siteUrl, link);
                    return replyToUrl;
                }

            }

            return string.Empty;
        }
    }
}
