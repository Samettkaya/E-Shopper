using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string AddressDetail { get; set; }
        public string AddressTitle { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int NeighbourhoodId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
 
    }
}
