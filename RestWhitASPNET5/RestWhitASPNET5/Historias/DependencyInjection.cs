using Microsoft.Extensions.DependencyInjection;
using RestWhitASPNET5.Historias.Calculations;
using RestWhitASPNET5.Historias.Validations;

namespace RestWhitASPNET5.Historias
{
    public static class DependencyInjection
    {
        public static IServiceCollection AdicionarDependencias(this IServiceCollection services) 
        {
            services.AddScoped<CalculateSum>();
            services.AddScoped<CalculateSubtraction>();
            services.AddScoped<Validation>();
            services.AddScoped<CalculateMultiplication>();
            services.AddScoped<CalculateSquare>();
            services.AddScoped<CalculateDivision>();
            services.AddScoped<CalculateMean>();

            return services;
        }
    }
}
