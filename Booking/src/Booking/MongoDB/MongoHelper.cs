using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Security.Authentication;

namespace Test.MongoDB
{
    public class MongoHelper
    {
        static string connectionString = @"mongodb://simplebooking:hnOZRKNujCFAeRgm32gA7KuGEgncaYR0sPxLdNZDsl05TtJDbkeBJl1x2212fxLIcjZZi11RHGCEhS5w0ET3OA==@simplebooking.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
        static string databaseName = @"simplebooking";

        public static MongoClient MongoClient
        {
            get
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
                settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
                var mongoClient = new MongoClient(settings);
                return mongoClient;
            }
        }

        public static IMongoDatabase MongoDatabase
        {
            get
            {
                return MongoClient.GetDatabase(databaseName);
            }
        }
    }
}
