using SectorOrange.API.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SectorOrange.API.Services.Interfaces
{
    public interface ICarInsuranceClaimService : IBaseRestService<CarInsuranceClaimDto, string>
    {
        Task<decimal> GetTotalDamageAmount();
    }
}
