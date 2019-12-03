using AutoMapper;
using SectorOrange.API.DAL;
using SectorOrange.API.DAL.Models;
using SectorOrange.API.Services.Interfaces;
using SectorOrange.API.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SectorOrange.API.Services.Services
{
    public class CarInsuranceClaimService : ICarInsuranceClaimService
    {
        private readonly ICarInsuranceRepository _carInsuranceRepository;

        public CarInsuranceClaimService(ICarInsuranceRepository carInsuranceRepository)
        {
            _carInsuranceRepository = carInsuranceRepository;
        }

        public async Task AddAsync(CarInsuranceClaimDto model)
        {
            var item = Mapper.Map<CarInsuranceClaim>(model);
            await _carInsuranceRepository.Add(item);
        }

        public async Task<decimal> GetTotalDamageAmount()
        {
            var carInsurances = await _carInsuranceRepository.GetAll();
            return carInsurances.SelectMany(x => x.ListOfDamages).Sum(x => x.EstimatedDamageAmount);
        }

        public async Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarInsuranceClaimDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CarInsuranceClaimDto> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(CarInsuranceClaimDto model)
        {
            throw new NotImplementedException();
        }
    }
}
