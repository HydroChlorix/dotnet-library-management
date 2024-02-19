using Infrastructure.Sentry;
using Sentry.Extensibility;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        return services;
    }

    public static IServiceCollection AddSentry(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddTransient<ISentryEventProcessor, SentryEventProcessor>();
        services.AddScoped<ISentryEventExceptionProcessor, SpecialExceptionProcessor>();

        services.AddSentry();

        return services;
    }

    public static IServiceCollection AddKeyVaultIfConfigured(this IServiceCollection services, ConfigurationManager configuration)
    {
        //var keyVaultUri = configuration["KeyVaultUri"];
        //if (!string.IsNullOrWhiteSpace(keyVaultUri))
        //{
        //    configuration.AddAzureKeyVault(
        //        new Uri(keyVaultUri),
        //        new DefaultAzureCredential());
        //}

        return services;
    }
}
