using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AddressCityUserDto:IDto
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string AddressDetail { get; set; }
        public string AddressTitle { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string NeighbourhoodName { get; set; }
  


    }
}
