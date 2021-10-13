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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;
        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }
        public IDataResult<List<OrderDetail>> GetAll()
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetailDal.GetAll(), Messages.GetOrderDetailGet);
        }

        public IDataResult<OrderDetail> GetById(int orderDetailId)
        {
            return new SuccessDataResult<OrderDetail>(_orderDetailDal.Get(o => o.Id==orderDetailId), Messages.GetOrderDetailGet);
        }
    }
}
