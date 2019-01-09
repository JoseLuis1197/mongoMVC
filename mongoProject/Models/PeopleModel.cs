using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mongoProject.Models
{
    public class PeopleModel
    {

        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("firstName")]
        public string firstName { get; set; }

        [BsonElement("middleName")]
        public string middleName { get; set; }

        [BsonElement("lastName")]
        public string lastName { get; set; }
              
    }

   

}