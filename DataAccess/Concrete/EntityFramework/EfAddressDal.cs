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
        public List<AddressCityUserDto> GetAddressCityUserDetails(Expression<Func<Address, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                var result = from a in filter is null ? context.Addresses : context.Addresses.Where(filter)
                             join c in context.Cities
                             on a.Id equals c.CityId
                             join u in context.Users
                             on a.UserId equals u.Id
                             select new AddressCityUserDto
                             {
                                 Id = a.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CityName = c.CityName,
                                 AddressDetail = a.AddressDetail,
                                 PostalCode = a.PostalCode
                             };
                             return result.ToList();
            }
        }

        public List<AddressDetailDto> GetAddressDetails(Expression<Func<Address, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                var result = from a in filter is null ? context.Addresses : context.Addresses.Where(filter)
                             join c in context.Cities
                             on a.Id equals c.CityId
                             select new AddressDetailDto
                             {
                                Id=a.Id,
                                PostalCode=a.PostalCode,
                                AddressDetail=a.AddressDetail,
                                CityName=c.CityName
                             };
                return result.ToList();
            }
        }
    }
}
