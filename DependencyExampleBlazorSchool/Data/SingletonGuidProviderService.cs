using System;

namespace DependencyExampleBlazorSchool.Data
{
    public class SingletonGuidProviderService : IGuidProviderService
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
