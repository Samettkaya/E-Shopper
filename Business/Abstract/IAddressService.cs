using Core.Utilities.Results;
using Entities.Concrete;
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
        IDataResult<List<Address>> GetAll();

    }
}
