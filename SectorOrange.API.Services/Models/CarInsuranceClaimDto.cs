using SectorOrgange.API.Shared.Models;
using System;
using System.Collections.Generic;

namespace SectorOrange.API.Services.Models
{
    public class CarInsuranceClaimDto : IBaseEntity<string>
    {
        public string PolicyNumber { get; set; }
        public CarInsuranceClaimPolicyHolderDto PolicyHolder { get; set; }
        public DateTime DamageDate { get; set; }
        public List<CarInsuranceClaimDamageDto> ListOfDamages { get; set; }

        public string Id { get; set; }
    }
}
