using MongoDB.Bson;
using MongoDB.Bson.IO;
using NUnit.Framework;
using System;

namespace Tests
{
    public class BsonDocumentTest
    {
        public BsonDocumentTest()
        {
            JsonWriterSettings.Defaults.Indent = true;

        }

        [Test]
        public void EmptyDocument()
        {
            var document = new BsonDocument();

            Console.WriteLine(document.ToJson());
        }

        [Test]
        public void AddElements()
        {
            var person = new BsonDocument
            {
                {"age",new BsonInt32(54) },
                {"isAlive",true }

            };

            person.Add("firstName",new BsonString("Bob"));
            Console.WriteLine(person.ToJson());
        }
    }
}