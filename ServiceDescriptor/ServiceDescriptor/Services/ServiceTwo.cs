using ServiceDescriptor.Interfaces;

namespace ServiceDescriptor.Services
{
    public class ServiceTwo : IService
    {
        public string GetService()
            => "ServiceTwo";
    }
}
