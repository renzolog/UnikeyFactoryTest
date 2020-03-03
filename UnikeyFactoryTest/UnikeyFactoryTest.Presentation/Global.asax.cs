﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using FluentValidation;
using FluentValidation.Mvc;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common.WebHost;
using UnikeyFactoryTest.Mapper.AutoMappers;
using UnikeyFactoryTest.NinjectConfiguration;
using UnikeyFactoryTest.Presentation.CustomValidators;
using UnikeyFactoryTest.Presentation.Models.DTO;
using UnikeyFactoryTest.Service;

namespace UnikeyFactoryTest.Presentation
{
    public class MvcApplication : NinjectHttpApplication
    {
        private IKernel kernel;
        protected override void OnApplicationStarted()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var mapConfig = new MapConfig();
            mapConfig.RegisterMap(CreateKernel());
        }

        protected override IKernel CreateKernel()
        {
            kernel = new StandardKernel();
            RegisterServices(kernel);
            return kernel;
        }

        private void RegisterServices(IKernel kernel)
        {
            kernel.Load(Assembly.GetExecutingAssembly());
            kernel.Load(new List<INinjectModule>
            {
                new AutoMapperBindingsService(),
                new UnikeyFactoryTestBindings()
            });
            kernel.Bind<IValidator<TestDto>>().To<TestValidator>();
            kernel.Bind<IValidator<QuestionDto>>().To<QuestionValidator>();
        }
    }
}
