﻿using MicroRabbit.Infra.IoC;

namespace MicroRabbit.Banking.Api.Extensions
{
    public static class Extensions
    {
        public static void RegisterServices(this IHostApplicationBuilder builder)
        {
            DependencyContainer.RegisterServices(builder.Services);
        }
    }
}
