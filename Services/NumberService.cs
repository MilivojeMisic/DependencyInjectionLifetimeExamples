using DependencyInjectionLifetime.Services;
using System;

namespace DependencyInjectionLifetimeExamples
{
    public class NumberService : INumberServiceTransient, INumberServiceScoped, INumberServiceSingleton
    {
        public int Number { get; private set; }

        public NumberService()
        {
            var random = new Random();
            Number = random.Next(1, 1000);
        }
    }
}
