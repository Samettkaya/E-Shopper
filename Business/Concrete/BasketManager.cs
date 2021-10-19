using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        //[SecuredOperation("admin")]
        [CacheRemoveAspect("IBasketService.Get")]
        //[ValidationAspect(typeof(BasketValidator))]
        public IResult Add(Basket basket)
        {
            _basketDal.Add(basket);
            return new SuccessResult(Messages.BasketAdd);
        }

        //[SecuredOperation("admin")]
        public IResult Delete(Basket basket)
        {
            _basketDal.Delete(basket);
            return new SuccessResult(Messages.BasketDelete);
        }

        public IDataResult<List<Basket>> GetAll()
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll(),Messages.BasketGetAll);
        }

        //[SecuredOperation("admin")]
        public IResult Update(Basket basket)
        {
            _basketDal.Update(basket);
            return new SuccessResult(Messages.BasketDelete);
        }
    }
}
