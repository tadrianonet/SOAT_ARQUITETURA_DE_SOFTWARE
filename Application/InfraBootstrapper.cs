using Application.UseCases;
using Dominio.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class InfraBootstrapper
{
    public static void Register(IServiceCollection services)
    {        
        services.AddTransient<IAuthenticationUseCase, AuthenticationUseCase>();
        services.AddTransient<IAuthenticationRepository, AuthenticationRepository>();
    }
}
