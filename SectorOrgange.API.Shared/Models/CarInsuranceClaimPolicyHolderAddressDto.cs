using System;
using System.Collections.Generic;
using System.Text;

namespace SectorOrgange.API.Shared.Models
{
    public class CarInsuranceClaimPolicyHolderAddressDto
    {
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
