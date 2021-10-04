using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AddressManager : IAddressService
    {

        IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult(Messages.AddressAdd);
        }

        public IResult Delete(Address address)
        {
            _addressDal.Delete(address);
            return new SuccessResult(Messages.AddressDelete);
        }

        public IResult Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult(Messages.AddressUpdate);
        }

        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll(), Messages.AddressGetAll);
        }

        public IDataResult<Address> GetById(int id)
        {
            return new SuccessDataResult<Address>(_addressDal.Get(a => a.Id ==id),Messages.AddressGetById);
        }

     
    }
}
