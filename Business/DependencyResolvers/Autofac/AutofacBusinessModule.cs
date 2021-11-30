using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<EfBasketDal>().As<IBasketDal>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<EfAddressDal>().As<IAddressDal>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();
            builder.RegisterType<EfOrderDetailDal>().As<IOrderDetailDal>();
            builder.RegisterType<EfSubCategoryDal>().As<ISubCategoryDal>();
            builder.RegisterType<EfASubCategoryDal>().As<IASubCategoryDal>();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>();
            builder.RegisterType<EfNeighbourhoodDal>().As<INeighbourhoodDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<BasketManager>().As<IBasketService>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<OrderDetailManager>().As<IOrderDetailService>();
            builder.RegisterType<SubCategoryManager>().As<ISubCategoryService>();
            builder.RegisterType<ASubCategoryManager>().As<IASubCategoryService>();
            builder.RegisterType<DistrictManager>().As<IDistrictService>();
            builder.RegisterType<NeighbourhoodManager>().As<INeighbourhoodService>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
