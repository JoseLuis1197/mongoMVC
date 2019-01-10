using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    class PocoTests
    {       
        public PocoTests()
        {
            JsonWriterSettings.Defaults.Indent = true;


        }

        public class Person
        {
            public string firstName { get; set; }
            public int age { get; set; }
            public List<string> address = new List<string>();
            public Contact contact = new Contact(); 
            [BsonIgnore]
            public string ignoreMe { get; set; }
            [BsonElement("new")]
            public string old { get; set; }
            [BsonElement]
            [BsonIgnoreIfNull]
            private string encapsulated { get; set; }
            [BsonRepresentation(BsonType.Double)]
            public decimal gravity { get; set; }
        }

        public class Contact
        {
            public string email { get; set; }
            public string phone { get; set; }
        }


        [Test]
        public void Automatic()
        {
            var person = new Person
            {
                age = 54,
                firstName = "Jose"                
                
            };

            person.address.Add("Av brasil 2980");
            person.address.Add("Armando 221");
            person.contact.email = "jose@example.com";
            person.contact.phone = "989542515";
            person.gravity = 12.33m;
            

            Console.WriteLine(person.ToJson());

        }

    }
}
