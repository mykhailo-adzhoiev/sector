using Microsoft.Extensions.Options;
using SectorOrange.API.DAL.Models;
using SectorOrgange.API.Shared;
using System;
using System.Threading.Tasks;

namespace SectorOrange.API.DAL
{
    public interface ICarInsuranceRepository : IBaseMongoRepository<CarInsuranceClaim>
    {

    }

    public class CarInsuranceRepository : BaseMongoRepository<CarInsuranceClaim>, ICarInsuranceRepository
    {
        public CarInsuranceRepository(IOptions<MongoDbOptions> settings)
        {
            _context = new CarInsuranceClaimContext(settings);
        }
    }
}
