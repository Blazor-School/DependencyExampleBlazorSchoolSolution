using System;

namespace DependencyExampleBlazorSchool.Data
{
    public class ScopedGuidProviderService : IGuidProviderService
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
