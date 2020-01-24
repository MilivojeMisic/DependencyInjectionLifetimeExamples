namespace DependencyInjectionLifetime.Services
{
    public interface INumberService
    {
        int Number { get; }
    }

    public interface INumberServiceTransient : INumberService
    {
    }

    public interface INumberServiceScoped : INumberService
    {
    }

    public interface INumberServiceSingleton : INumberService
    {
    }
}