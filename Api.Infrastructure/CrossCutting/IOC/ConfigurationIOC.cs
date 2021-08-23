using Api.Application;
using Api.Application.Interfaces;
using Api.Domain.Core.Interfaces.Repository;
using Api.Domain.Core.Services;
using Api.Domain.Services;
using Api.Infrastructure.CrossCutting.Interfaces;
using Api.Infrastructure.CrossCutting.Mapper;
using Api.Infrastructure.Data.Repositorys;
using Autofac;
using AutoMapper;

namespace Api.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ApplicationServiceCategory>().As<IApplicationServiceCategory>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<ServiceCategory>().As<IServiceCategory>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<RepositoryCategory>().As<IRepositoryCategory>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();
            builder.RegisterType<MapperCategory>().As<IMapperCategory>();
        }
    }
}
