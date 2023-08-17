using System;
using ElasticIngest.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace ElasticIngest
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            // Register your services here
            builder.Services.AddSingleton<IElasticSearchQueryService, ElasticSearchQueryService>();
        }
    }
}