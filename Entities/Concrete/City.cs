using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class City : IEntity

    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int PlateNo { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}