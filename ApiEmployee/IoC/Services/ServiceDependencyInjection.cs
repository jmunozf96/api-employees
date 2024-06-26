﻿using ApiEmployee.Domain.Ports.In.Usecases;
using Application.Commands;
using Application.Queries;
using Application.Services;
using Domain.Ports.In.Commands;
using Domain.Ports.In.Queries;
using Domain.Ports.In.Services;
using ErpSecurity.Application.Usecases;
using ErpSecurity.Domain.Ports.In.Usecases;

namespace ErpIoc
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection AddServiceDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ICreateDefaultUserCommandHandler, CreateDefaultUserCommandHandler>();
            services.AddScoped<ICreateEmployeeCommandHandler, CreateEmployeeCommandHandler>();
            services.AddScoped<IUpdateEmployeeCommandHandler, UpdateEmployeeCommandHandler>();
            services.AddScoped<IGetEmployeeQueryHandler, GetEmployeeQueryHandler>();
            services.AddScoped<IRemoveEmployeeCommandHandler, RemoveEmployeeCommandHandler>();
            services.AddScoped<IGetAllEmployeeQueryHandler, GetAllEmployeeQueryHandler>();
            services.AddScoped<ISignInUseCase, SignInUseCase>();
            services.AddScoped<IGetAccessTokenUseCase, GetAccessTokenUseCase>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;
        }
    }
}
