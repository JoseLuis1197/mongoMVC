using MongoDB.Driver;
using mongoProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace mongoProject.App_Start
{
    public class MongoDBContext
    {
        private IMongoDatabase _database { get; }

        public MongoDBContext()
        {
            var serverName = ConfigurationManager.AppSettings["serverName"];
            var dataBaseName = ConfigurationManager.AppSettings["dataBaseName"];


            try
            {
              
                var mongoClient = new MongoClient(serverName);
                _database = mongoClient.GetDatabase(dataBaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Can not access to db server.", ex);
            }
        }

        public IMongoCollection<PeopleModel> connection
        {
            get
            {
                return _database.GetCollection<PeopleModel>("cPeople");
            }
        }

    }
}