using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Neighbourhood : IEntity

    {
        public int NeighbourhoodId { get; set; }
        public int DistictId { get; set; }
        public string NeighbourhoodName { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }

    }
}