using Microsoft.Extensions.DependencyInjection;

namespace RestWhitASPNET5.Historias
{
    public static class InjecaoDeDependencia
    {
        public static IServiceCollection AdicionarDependencias(this IServiceCollection services) 
        {
            services.AddScoped<CalcularSoma>();
            services.AddScoped<CalcularSubtracao>();
            return services;
        }
    }
}
