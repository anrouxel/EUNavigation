using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text;

public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
{
    readonly IApiVersionDescriptionProvider provider;

    public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) =>
      this.provider = provider;

    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in provider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(
              description.GroupName,
                new OpenApiInfo()
                {
                    Title = $"EUNavigation - Data API",
                    Version = description.ApiVersion.ToString(),
                    Description = "L'API de données EUNavigation offre un accès complet aux informations détaillées sur les horaires de transport en commun et autres données de navigation à travers l'Europe. Cette API permet aux développeurs d'accéder aux horaires théoriques et en temps réel, aux itinéraires, aux informations sur les arrêts de bus, aux gares et aux lignes de transport. Utilisez cette API pour intégrer facilement des fonctionnalités de planification de trajets, de suivi en temps réel et d'exploration des options de transport en commun à votre application. Veuillez noter que certaines fonctionnalités avancées de l'API peuvent nécessiter une authentification.",
                });
        }
    }
}