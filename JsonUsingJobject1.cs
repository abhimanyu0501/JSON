using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcept
{
    class JsonUsingJobject1
    {

        static void Main()
        {
            JsonUsingJobject1 jujo = new JsonUsingJobject1();
            jujo.ParseJsonIntoDotnetObject();
        }
    private void ParseJsonIntoDotnetObject()
        {
            string json = @"{
  CPU: 'Intel',
  Drives: [
    'DVD read/writer',
    '500 gigabyte hard drive'
  ]
}";

 dynamic o = JObject.Parse(json);

            Console.Write(o.CPU);
            
        }
    }
}
