using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcept
{
    class JSonUsingJObject
    {
        static void Main(String[] args)
        {
            var tag = GetDynamicDataForTag("{\"DemandRate\":0.5556}");
            Console.WriteLine(tag.DemandRate);
            Console.WriteLine(tag.DemandRate==null);
            Console.WriteLine(tag.Hello==null);
            Console.ReadLine();
        }
 //dynamic - Represents an object whose operation will be resolved at runtime.
        private static dynamic GetDynamicDataForTag(string json)
        {
//Parse(json) - Loads a JObject from a string that contains JSON.
            return JObject.Parse(json);
        }
            
    }
}
