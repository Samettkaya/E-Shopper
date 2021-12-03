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
    public class ASubCategoryManager : IASubCategoryService
    {

        IASubCategoryDal _aSubCategoryDal;

        public ASubCategoryManager(IASubCategoryDal aSubCategoryDal)
        {
            _aSubCategoryDal = aSubCategoryDal;
        }

        public IResult Add(ASubCategory aSubCategory)
        {
            _aSubCategoryDal.Add(aSubCategory);
            return new SuccessResult(Messages.ASubCategoryAdd);
                
        }

        public IResult Delete(ASubCategory aSubCategory)
        {
            _aSubCategoryDal.Delete( aSubCategory);
            return new SuccessResult(Messages.ASubCategoryDelete);

        }

        public IDataResult<List<ASubCategory>> GetAll()
        {
            return new SuccessDataResult<List<ASubCategory>>(_aSubCategoryDal.GetAll(),Messages.ASubCategoryGetAll);
        }

        public IDataResult<ASubCategory> GetById(int id)
        {
            return new SuccessDataResult<ASubCategory>(_aSubCategoryDal.Get(c=>c.Id==id), Messages.ASubCategoryGetById);
        }

        public IResult Update(ASubCategory aSubCategory)
        {
            _aSubCategoryDal.Update(aSubCategory);
            return new SuccessResult(Messages.ASubCategoryUpdate);
        }
    }
}
