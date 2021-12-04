using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface INeighbourhoodService
    {
        IResult Add(Neighbourhood neighbourhood);
        IResult Delete(Neighbourhood neighbourhood);
        IResult Update(Neighbourhood neighbourhood);
        IDataResult<Neighbourhood> GetById(int Id);
        IDataResult<List<Neighbourhood>> GetAll();

    }
}
