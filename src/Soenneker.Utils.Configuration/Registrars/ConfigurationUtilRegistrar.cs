using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Utils.Configuration.Abstract;

namespace Soenneker.Utils.Configuration.Registrars;

/// <summary>
/// A utility library for configuration related operations
/// </summary>
public static class ConfigurationUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IConfigurationUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddConfigurationUtilAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<IConfigurationUtil, ConfigurationUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IConfigurationUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddConfigurationUtilAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IConfigurationUtil, ConfigurationUtil>();

        return services;
    }
}
