using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace DataAccess.Abstract
{
    public interface IAddressDal : IEntityRepository<Address>
    {
       
       // List<AddressCityUserDto> GetAddressCityUserDetails(Expression<Func<Address, bool>> filter = null);
    }
}
