using System;
using System.Collections.Generic;
using System.Text;

namespace SectorOrgange.API.Shared.Models
{
    public class CarInsuranceClaimPolicyHolderDto
    {
        public string Initials { get; set; }
        public string Name { get; set; }
        public CarInsuranceClaimPolicyHolderAddressDto Address { get; set; }
    }
}
