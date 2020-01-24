namespace DependencyInjectionLifetimeExamples.Services
{
    public interface IConsumerService
    {
        int GetNumberFromTransientService();

        int GetNumberFromScopedService();

        int GetNumberFromSingletonService();
    }
}