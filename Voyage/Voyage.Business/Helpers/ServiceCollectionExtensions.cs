﻿using Microsoft.Extensions.DependencyInjection;
using Voyage.Business.Services;
using Voyage.Business.Services.Interfaces;

namespace Voyage.Business.Helpers
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITransportTypeService, TransportTypeService>();

            return services;
        }
    }
}