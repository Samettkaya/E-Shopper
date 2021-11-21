using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, Context>, IProductDal
    {

        public List<ProductDetailDto> GetProductDetail(Expression<Func<Product, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                var result = from p in filter is null ? context.Products : context.Products.Where(filter)
                             join b in context.Brands
                             on p.Id equals b.Id
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             select new ProductDetailDto
                             {
                                BrandName = b.Name,
                                CategoryName = c.Name,
                                Price = p.Price,
                                Id = p.Id,
                                Code=p.Code,
                                ProductName=p.Name

                             };
                return result.ToList();
            }
        }
    }
}
