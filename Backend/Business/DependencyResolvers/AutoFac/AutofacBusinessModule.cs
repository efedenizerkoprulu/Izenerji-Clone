using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModule : Module
    {
        /// <summary>
        /// In order to get rid of dependency and under the name of clean code, 
        /// we can create an example of this structure without creating something new.
        /// </summary>

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ImageItemManeger>().As<IImageItemService>();
            builder.RegisterType<EfImageItemDal>().As<IImageItemDal>();

            builder.RegisterType<SliderManager>().As<ISliderService>();
            builder.RegisterType<EfSliderDal>().As<ISliderDal>();

            builder.RegisterType<AbilityManager>().As<IAbilityService>();
            builder.RegisterType<EfAbilityDal>().As<IAbilityDal>();

            builder.RegisterType<ArticleManager>().As<IArticleService>();
            builder.RegisterType<EfArticleDal>().As<IArticleDal>();

            builder.RegisterType<ChartDataManager>().As<IChartDataService>();
            builder.RegisterType<EfChartDataDal>().As<IChartDataDal>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            builder.RegisterType<TwitterManager>().As<ITwitterService>();
            builder.RegisterType<EfTwitterDal>().As<ITwitterDal>();

        }
    }
}
