using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        //[SecuredOperation("admin")]
        [CacheRemoveAspect("IAddressService.Get")]
        [ValidationAspect(typeof(AddressValidator))]
        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult(Messages.AddressAdd);
        }

        //[SecuredOperation("admin")]
        public IResult Delete(Address address)
        {
            _addressDal.Delete(address);
            return new SuccessResult(Messages.AddressDelete);
        }

        //[SecuredOperation("admin")]
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


     

        public IDataResult<List<Address>> GetByUsers(int userId)
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll(a => a.UserId == userId), Messages.AddressGetById);
        }

        public IDataResult<List<AddressCityUserDto>> GetAddressCityUserDetails(int userId)
        {
            return new SuccessDataResult<List<AddressCityUserDto>>(_addressDal.GetAddressCityUserDetails(a=>a.UserId== userId),Messages.AddressGetAllDetail);   
        }
    }
}
