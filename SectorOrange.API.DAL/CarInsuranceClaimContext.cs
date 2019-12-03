using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SectorOrange.API.DAL.Models;
using SectorOrgange.API.Shared;

namespace SectorOrange.API.DAL
{
    public class CarInsuranceClaimContext : BaseMongoContext<CarInsuranceClaim>
    {
        private const string COLLECTION_NAME = "CarInsuranceClaims";

        public CarInsuranceClaimContext(IOptions<MongoDbOptions> settings) : base(settings)
        {
        }

        public override IMongoCollection<CarInsuranceClaim> Entity
        {
            get
            {
                return _database.GetCollection<CarInsuranceClaim>(COLLECTION_NAME);
            }
        }
    }
}
