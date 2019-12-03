using AutoMapper;
using SectorOrange.API.DAL.Models;
using SectorOrange.API.Services.Models;

namespace SectorOrange.API.Web.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarInsuranceClaimDto, CarInsuranceClaim>();
        }
    }
}
