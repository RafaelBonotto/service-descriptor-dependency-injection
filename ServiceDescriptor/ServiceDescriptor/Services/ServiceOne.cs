using ServiceDescriptor.Interfaces;

namespace ServiceDescriptor.Services
{
    public class ServiceOne : IService
    {
        public string GetService()
        => "ServiceOne";
    }
}
