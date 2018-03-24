using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcept
{
    class JSonDeSerialization
    {
        static void Main(String[] args)
        {
            string json = "{\"Description\":\"Share Knowledge\",\"Name\":\"C-sharpcorner\"}";

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(BlogSite1));
//Reads a document stream in the JSON format.and return the deserialized object.
                BlogSite1 bsObj2 = (BlogSite1)deserializer.ReadObject(ms);
                Console.WriteLine("Name: "+bsObj2.Name);
                Console.WriteLine("Discription: "+bsObj2.Description);
                Console.ReadLine();
            }

                }
    }
}
