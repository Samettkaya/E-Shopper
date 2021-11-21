using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IResult Add(Address address);
        IResult Update(Address address);
        IResult Delete(Address address);
        IDataResult<Address> GetById(int id);
        IDataResult<List<Address>> GetByUsers(int userId);
        IDataResult<List<Address>> GetAll();
        IDataResult<List<AddressDetailDto>> GetAllAddressDetail();
        IDataResult<List<AddressCityUserDto>> AddressCityUserDto();
    }
}
