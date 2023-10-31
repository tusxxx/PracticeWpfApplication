using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace PracticeWpfApplication.Database
{
    public class DatabaseDao
    {
        private readonly IMongoDatabase _database;
        private IMongoCollection<Customer> BuyersCollection => _database.GetCollection<Customer>("Покупатели");
        private IMongoCollection<Product> ProductsCollection => _database.GetCollection<Product>("Товары");
        private IMongoCollection<Selling> SellingsCollection => _database.GetCollection<Selling>("Заказы");

        // Constructor
        public DatabaseDao(string connectionString, string databaseName)
        {
            var url = MongoUrl.Create(connectionString);
            var mongoClient = new MongoClient(url);
            var a = mongoClient.StartSession();
            _database = mongoClient.GetDatabase(databaseName);
        }

        public List<Customer> GetAllBuyers()
        {
            var result = BuyersCollection.Find(Builders<Customer>.Filter.Empty).ToList();
            return result;
        }
        
        public async Task<List<Product>> GetAllProducts()
        {
            var result = await ProductsCollection.Find(Builders<Product>.Filter.Empty).ToListAsync();
            return result;
        }

        public async Task<List<Selling>> GetAllSellings()
        {
            var result = await SellingsCollection.Find(Builders<Selling>.Filter.Empty).ToListAsync();
            return result;
        }
    }
}