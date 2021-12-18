using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class District : IEntity

    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int CityId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
       
    }
}
