using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Neighbourhood : IEntity
    {
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public string NeighbourhoodName { get; set; }
        public string PostalCode { get; set; }
    }
}