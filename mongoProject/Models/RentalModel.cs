using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mongoProject.Models
{
    public class RentalModel
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id  { get; set; }
        public string description { get; set; }
        public int numberOfRooms { get; set; }
        public List<string> address = new List<string>();
        [BsonRepresentation(BsonType.Double)]
        public decimal price { get; set; }

        public object tobsondocument()
        {
            throw new NotImplementedException();
        }
    }
}