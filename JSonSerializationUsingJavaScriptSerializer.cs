using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace LoopConcept
{
    class JSonSerializationUsingJavaScriptSerializer
    {
        static void Main(String[] args)
        {
            JSonSerializationUsingJavaScriptSerializer jsujs = new JSonSerializationUsingJavaScriptSerializer();
            jsujs.Serialize();
        }

            public string Serialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "C-sharpcorner",
                Description = "Share Knowledge"
            };

            //Serializing object to json data
            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(bsObj);
            Console.WriteLine(jsonData);
            Console.ReadLine();
            return jsonData;
            

        }

        public void DeSerialize(string jsonData)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            BlogSites blogObject = js.Deserialize<BlogSites>(jsonData);
            string name = blogObject.Name;
            string description = blogObject.Description;

            //Other way to without help of BlogSites class
            dynamic blogObject1 = js.Deserialize<dynamic>(jsonData);
            string name1 = blogObject1["Name"];
            string discription1 = blogObject1["Description"];

            Console.ReadLine();
        }
        
    }
    //[DataContract]
    class BlogSites
    {
       // [DataMember]
        public string Name { get; set; }
       // [DataMember]
        public string Description { get; set; }
    }
}
