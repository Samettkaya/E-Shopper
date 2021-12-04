using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICityService
    {
        IResult Add(City city);
        IResult Delete(City city);
        IResult Update(City city);
        IDataResult<City> GetById(int id);
        IDataResult<List<City>> GetAll();
    }
}
