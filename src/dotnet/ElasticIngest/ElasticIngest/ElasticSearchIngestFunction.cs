using System;
using ElasticIngest.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ElasticIngest
{
    public class ElasticSearchIngestFunction
    {
        private readonly IElasticSearchQueryService _elasticSearchQueryService;

        public ElasticSearchIngestFunction(IElasticSearchQueryService elasticSearchQueryService)
        {
            _elasticSearchQueryService = elasticSearchQueryService;
        }

        [FunctionName("ElasticIngest")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}