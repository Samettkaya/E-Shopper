using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal : EfEntityRepositoryBase<Address, Context>, IAddressDal
    {
        //public List<AddressCityUserDto> GetAddressCityUserDetails(Expression<Func<Address, bool>> filter = null)
        //{
        //    using (Context context = new Context())
        //    {
        //        var result = from address in filter is null ? context.Addresses : context.Addresses.Where(filter)
        //                     join city in context.Cities
        //                     on address.Id equals city.Id
        //                     join user in context.Users
        //                     on address.UserId equals user.Id
        //                     join district in context.Districts
        //                     on address.DistrictId equals district.Id
        //                     join neighbourhood in context.Neighbourhoods
        //                     on address.NeighbourhoodId equals neighbourhood.NeighbourhoodId

        //                     select new AddressCityUserDto
        //                     {
        //                         //Id = address.Id,
                               
        //                         //LastName = user.LastName,
        //                         //Email = user.Email,
        //                         ////CityName = city.CityName,
        //                         ////DistrictName=district.DistrictName,
        //                         ////NeighbourhoodName=neighbourhood.NeighbourhoodName,
        //                         //PostalCode=neighbourhood.PostalCode,
        //                         //AddressDetail =  address.AddressDetail
                              
        //                     };
        //                     return result.ToList();
        //    }
        //}

     
    }
}
