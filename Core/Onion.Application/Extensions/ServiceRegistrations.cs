using Microsoft.Extensions.DependencyInjection;
using Onion.Application.Features.CQRS.Handlers;
using Onion.Application.Interfaces;

namespace Onion.Application.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddApplicationExt(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceRegistrations).Assembly);

            services.AddScoped<GetCategoryQueryHandler>();

        }

    }
}
