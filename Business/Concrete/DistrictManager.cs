using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        //[SecuredOperation("admin")]
        [CacheRemoveAspect("IDistrictService.Get")]
        [ValidationAspect(typeof(DistrictValidator))]
        public IResult Add(District district)
        {
            _districtDal.Add(district);
            return new SuccessResult(Messages.DistrictAdd);
        }

        public IResult Delete(District district)
        {
            _districtDal.Delete(district);
            return new SuccessResult(Messages.DistrictDelete);
        }

        public IDataResult<List<District>> GetAll()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetAll(),Messages.DistrictGetAll);
            
        }

        public IDataResult<District> GetById(int id)
        {
            return new SuccessDataResult<District>(_districtDal.Get(d => d.Id == id),Messages.DistrictGetById);
        }

        public IResult Update(District district)
        {
            _districtDal.Update(district);
            return new SuccessResult(Messages.DistrictUpdate);
        }
    }
}
