using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class District : IEntity

    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}
