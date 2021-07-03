using System;

namespace DependencyExampleBlazorSchool.Data
{
    public class TransientGuidProviderService : IGuidProviderService
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
