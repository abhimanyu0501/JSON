using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcept
{
    class JSonUsingObjectofArray
    {
        static void Main(String[] args)
        {
            JSonUsingObjectofArray juoa = new JSonUsingObjectofArray();
            juoa.serialize();
        }
        public void serialize()
        {
            string json = "{\"d\":[{\"numberOfRowsAdded\":\"26723\"}]}";
            JObject uploadData = JObject.Parse(json);
            int rowsAdded = Convert.ToInt32((string)uploadData["d"][0]["numberOfRowsAdded"]);
            Console.WriteLine(rowsAdded);
            Console.ReadLine();
        }

    }
}
