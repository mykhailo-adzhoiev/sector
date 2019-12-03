using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SectorOrgange.API.Shared.Models;
using System;
using System.Collections.Generic;

namespace SectorOrange.API.DAL.Models
{
    public class CarInsuranceClaim
    {
        [BsonId]
        public ObjectId InternalId { get; set; }

        public string Id { get; set; }
        public string PolicyNumber { get; set; }
        public CarInsuranceClaimPolicyHolderDto PolicyHolder { get; set; }

        [BsonDateTimeOptions]
        public DateTime DamageDate { get; set; }
        public List<CarInsuranceClaimDamageDto> ListOfDamages { get; set; }
    }
}
