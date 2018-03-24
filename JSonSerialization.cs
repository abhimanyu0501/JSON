using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
/*
  Serialization is a process , it converts a custom .Net object to a JSON string.
*/

namespace LoopConcept
{
    class JSonSerialization
    {
static void Main(String[] args)
        {
            BlogSite1 bsObj = new BlogSite1()
            {
                Name = "C-sharpcorner",
                Description = "Share Knowledge"
            };
//Serializes objects to the json.and deserialize json data to object. this class cannot be inherited.
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(BlogSite1));
            //creating a stream whose backing store is memory.
            MemoryStream msObj = new MemoryStream();
//Serializes a specific object to json data and writes the resulting json to a stream.
            js.WriteObject(msObj, bsObj);
//set or get the current position within the stream.
            msObj.Position = 0;
//Implements a TextReader that reads character from a byte stream in a particular encoding.
            StreamReader sr = new StreamReader(msObj);
//Reads all characters from the current position to the end of stream.
            string json = sr.ReadToEnd();
            Console.WriteLine(json);
            sr.Close();
            msObj.Close();
            Console.ReadLine();

        }
    }
    //Specifies that the type defines or implements a data contract and is serializable by a serializer,such as the DataContractSerializer.To make their type serializable,type author
//must define a data contract for their type.
    [DataContract]
     class BlogSite1
    {
//when applied to the member of a type,specifies that the member is part of data contract and is serializable by the DataContractSerializable.
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
