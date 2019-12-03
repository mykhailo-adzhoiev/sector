using Microsoft.AspNetCore.Mvc;
using SectorOrange.API.Services.Interfaces;
using SectorOrange.API.Services.Models;
using System.Threading.Tasks;

namespace SectorOrange.API.Web.Controllers
{
    /// <summary>
    /// Rest API Controller to use with Car Insurance Claim Service that works with CarInsuranceClaimDto and entity ID as string type
    /// (Assuming that we already know that ID is string type like _objectId in Mongo)
    /// </summary>
    public class CarInsuranceClaimController : BaseRestController<ICarInsuranceClaimService, CarInsuranceClaimDto, string>
    {
        private readonly ICarInsuranceClaimService _carInsuranceClaimService;
        public CarInsuranceClaimController(ICarInsuranceClaimService carInsuranceClaimService) : base(carInsuranceClaimService)
        {
            _carInsuranceClaimService = carInsuranceClaimService;
        }

        [HttpGet("totalDamage")]
        public async Task<IActionResult> CalculateTotalDamageAmount()
        {
            var result = await _carInsuranceClaimService.GetTotalDamageAmount();
            return Ok(result);
        }
    }
}
