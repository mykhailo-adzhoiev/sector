using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SectorOrgange.API.Shared;

namespace SectorOrange.API.DAL
{
    public class BaseMongoContext<T>
    {
        protected readonly IMongoDatabase _database;

        public BaseMongoContext(IOptions<MongoDbOptions> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);

            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public virtual IMongoCollection<T> Entity { get; }
    }
}
