using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcept
{
    class JSonDeSerializationUsingNewtonSoft
    {

        public static void Main(String[] args)
        {
            JSonDeSerializationUsingNewtonSoft jdun = new JSonDeSerializationUsingNewtonSoft();
            jdun.Deserialize();
        }
        public void Deserialize()
        {
            string json = @"{
                            'Name': 'C-sharpcorner',
                            'Description': 'Share Knowledge'
                            }";
            //JsonConvert - Provides methods for converting between .NET types and json types.
            //DeserializeObject() - Deseralize the json object to a specify .Net type.
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
            Console.ReadLine();
        }
    }

    

}
