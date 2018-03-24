using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcept
{
    class JSonSerializationUsingNewtonSoft
    {
        static void Main(String[] args)
        {
            JSonSerializationUsingNewtonSoft jsun = new JSonSerializationUsingNewtonSoft();
            jsun.Serialize();
        }

        public void Serialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "C-sharpcorner",
                Description = "Share Knowledge"
            };
            //Convert BlogSites object to JSON string format
            //JsonConvert - Provides methods for converting between json types and .net types.
            //SerializeObject() - serializes the specified object to a JSON string.
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.Write(jsonData);
            Console.ReadLine();

        }
    }
}
