using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IASubCategoryService
    {
        IDataResult<List<ASubCategory>> GetAll();
        IDataResult<ASubCategory> GetById(int id);
        IResult Add(ASubCategory aSubCategory);
        IResult Delete(ASubCategory aSubCategory);
        IResult Update(ASubCategory aSubCategory);
    }
}
