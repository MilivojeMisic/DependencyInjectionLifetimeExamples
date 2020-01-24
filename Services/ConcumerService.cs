using DependencyInjectionLifetime.Services;
using System;

namespace DependencyInjectionLifetimeExamples.Services
{
    public class ConsumerService : IConsumerService
    {
        private readonly INumberServiceTransient transientNumberService;
        private readonly INumberServiceScoped scopedNumberService;
        private readonly INumberServiceSingleton singletonNumberService;

        public ConsumerService(INumberServiceTransient transientNumberService,
            INumberServiceScoped scopedNumberService,
            INumberServiceSingleton singletonNumberService)
        {
            this.transientNumberService = transientNumberService;
            this.scopedNumberService = scopedNumberService;
            this.singletonNumberService = singletonNumberService;
        }

        public int GetNumberFromTransientService()
        {
            return transientNumberService.Number;
        }

        public int GetNumberFromScopedService()
        {
            return scopedNumberService.Number;
        }

        public int GetNumberFromSingletonService()
        {
            return singletonNumberService.Number;
        }
    }
}