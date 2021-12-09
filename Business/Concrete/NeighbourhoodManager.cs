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
    public class NeighbourhoodManager : INeighbourhoodService
    {
        INeighbourhoodDal _neighbourhoodDal;

        public NeighbourhoodManager(INeighbourhoodDal neighbourhoodDal)
        {
            _neighbourhoodDal = neighbourhoodDal;
        }

        public IResult Add(Neighbourhood neighbourhood)
        {
            _neighbourhoodDal.Add(neighbourhood);
            return new SuccessResult(Messages.NeighbourhoodAdd);
        }

        public IResult Delete(Neighbourhood neighbourhood)
        {
            _neighbourhoodDal.Delete(neighbourhood);
            return new SuccessResult(Messages.NeighbourhoodDelete);
        }

        public IDataResult<List<Neighbourhood>> GetAll()
        {
            return new SuccessDataResult<List<Neighbourhood>>(_neighbourhoodDal.GetAll(),Messages.NeighbourhoodGetAll);
        }

        public IDataResult<Neighbourhood> GetById(int Id)
        {
            return new SuccessDataResult<Neighbourhood>(_neighbourhoodDal.Get(n => n.Id == Id),Messages.NeighbourhoodGetById);
        }

        public IResult Update(Neighbourhood neighbourhood)
        {
            _neighbourhoodDal.Update(neighbourhood);
            return new SuccessResult(Messages.NeighbourhoodUpdate);
        }
    }
}
