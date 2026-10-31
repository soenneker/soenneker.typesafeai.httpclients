using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.TypesafeAi.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.TypesafeAi.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class TypesafeAiOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="TypesafeAiOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddTypesafeAiOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ITypesafeAiOpenApiHttpClient, TypesafeAiOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="TypesafeAiOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddTypesafeAiOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ITypesafeAiOpenApiHttpClient, TypesafeAiOpenApiHttpClient>();

        return services;
    }
}
