using MongoDB.Bson;
using mongoProject.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace tests.Rentals
{
    [TestFixture]
    public class RentalTests : AssertionHelper
    {
        [Test]
        public void toDocument_RentalWithPrice_PriceRepresentedAsDouble() {

            var rental = new RentalModel();
            rental.price = 1;

            var document = rental.ToBsonDocument();

            Expect(document["price"].BsonType, Is.EqualTo(BsonType.Double));
        }

        [Test]
        public void toDocument_RentalWithAnId_IdIsRepresentedAsObjectId()
        {

            var rental = new RentalModel();
            rental.id = ObjectId.GenerateNewId().ToString();

            var document = rental.ToBsonDocument();

            Expect(document["_id"].BsonType, Is.EqualTo(BsonType.ObjectId));
        }



    }
}
