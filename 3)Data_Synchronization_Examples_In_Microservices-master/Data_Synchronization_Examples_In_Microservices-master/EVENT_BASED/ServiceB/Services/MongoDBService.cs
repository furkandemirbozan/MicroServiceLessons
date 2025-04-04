using MongoDB.Driver;

namespace ServiceB.Services
{
    public class MongoDBService
    {
        readonly IMongoDatabase _database;
        public MongoDBService(IConfiguration configuration)
        {
            // MongoDB bağlantı dizesini appsettings.json dosyasına ekleyin
            MongoClient client = new(configuration.GetConnectionString("MongoDB"));
            _database = client.GetDatabase("ServiceBDB");
        }

        public IMongoCollection<T> GetCollection<T>() => _database.GetCollection<T>(typeof(T).Name.ToLowerInvariant());
    }
}
