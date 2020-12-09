using Prometheus.Core.Interfaces.Services.Account;
using Prometheus.Core.IoC;
using Prometheus.Service.Services.Account;
using Unity;

namespace Prometheus.Web.IoC
{
    public class UnityDependencyProvider : IDependencyProvider
    {
        public void RegisterDependencies(IUnityContainer container)
        {
            container.RegisterType<ILoginService, LoginService>();
        }
    }
}
