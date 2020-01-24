using DependencyInjectionLifetime.Services;
using DependencyInjectionLifetimeExamples.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionLifetimeExamples.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConsumerService consumerService;
        private readonly INumberServiceTransient transientNumberService;
        private readonly INumberServiceScoped scopedNumberService;
        private readonly INumberServiceSingleton singletonNumberService;

        public HomeController(
            IConsumerService consumerService,
            INumberServiceTransient transientNumberService,
            INumberServiceScoped scopedNumberService,
            INumberServiceSingleton singletonNumberService)
        {
            this.consumerService = consumerService;
            this.transientNumberService = transientNumberService;
            this.scopedNumberService = scopedNumberService;
            this.singletonNumberService = singletonNumberService;
        }
        public IActionResult Index()
        {
            var output = @$"First usage (in the controller): 
                Transient service result: {transientNumberService.Number}
                Scoped service result: {scopedNumberService.Number}
                Singleton service result: {singletonNumberService.Number}

            Second usage (in the consumer service):
                Transient service result: {consumerService.GetNumberFromTransientService()}
                Scoped service result: {consumerService.GetNumberFromScopedService()}
                Singleton service result: {consumerService.GetNumberFromSingletonService()}" ;

            return Content(output);
        }
    }
}