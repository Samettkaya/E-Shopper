using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal : EfEntityRepositoryBase<Address, Context>, IAddressDal
    {
        public List<AddressDetailDto> GetAddressDetails(Expression<Func<Address, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
