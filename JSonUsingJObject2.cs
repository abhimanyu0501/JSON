using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcept
{
    class JSonUsingJObject2
    {
        public static void Main(string[] args)
        {
            JSonUsingJObject2 juo = new JSonUsingJObject2();
            juo.ParseJson();
        }

        public void ParseJson()
        {
            string json = @"{'channel':
{
'title': 'James Newton-King',
'link':'http://james.newtonking.com',
'description':'James Newton-King\'s blog',
'item':[
{
'title':'Json.NET 1.3 + New license + Now on CodePlex',
'description':'Annoucing the release of Json.NET 1.3, the MIT license and the source on CodePlex',
'link':'http://james.newtonking.com/projects/json-net.aspx',
'categories':['Json.NET',
          'CodePlex']
},

{
'title':'LINQ to JSON beta',
'description': 'Annoucing LINQ to JSON',
'link':'http://james.newtonking.com/projects/json-net.aspx',
'categories': [
'Json.NET',
'LINQ'
]
}
]}}";

            JObject rss = JObject.Parse(json);
            rss.Add("school",JObject.Parse("{ \"name\":\"AV\",\"age\":4}"));
            string rssTitle = (string)rss["channel"]["title"];
            string itemTitle =(string) rss["channel"]["item"][0]["title"];
            JArray categories = (JArray)rss["channel"]["item"][0]["categories"];
           int school = (int)rss["channel"]["school"]["name"];
            IList<string> categoriesText = categories.Select(c => (string)c).ToList();
            Console.WriteLine(rssTitle);
            Console.WriteLine(itemTitle);
            Console.WriteLine(categories);
            //Console.WriteLine(school);
            Console.WriteLine(rss.GetValue("title"));
            Console.ReadLine();

        }
    }
}
