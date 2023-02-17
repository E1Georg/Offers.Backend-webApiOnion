using Microsoft.Extensions.DependencyInjection;
using System;
using MediatR;
using System.Reflection;
using FluentValidation;
using ArtistTitles.Application.Common.Behaviors;

namespace ArtistTitles.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblies(new[] {Assembly.GetExecutingAssembly() });
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services;
        }
    }
}
