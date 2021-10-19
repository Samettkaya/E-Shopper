using Business.Abstract;
using Business.Constants;
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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        //[SecuredOperation("order.add,admin")]
        [CacheRemoveAspect("IOrderService.Get")]
        //[ValidationAspect(typeof(OrderValidator))]

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdd);
        }

        //[SecuredOperation("order.delete,admin")]
        public IResult Delete(Order order)
        {
            return new SuccessResult(Messages.OrderDelete);
        }
    }
}
