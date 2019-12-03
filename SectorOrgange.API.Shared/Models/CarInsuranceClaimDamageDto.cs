using System;
using System.Collections.Generic;
using System.Text;

namespace SectorOrgange.API.Shared.Models
{
    public class CarInsuranceClaimDamageDto
    {
        public DamageType DamageType { get; set; }
        public decimal EstimatedDamageAmount { get; set; }
    }
}
