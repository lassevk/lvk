using LVK.Core.Bootstrapping;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LVK.Data.EntityFramework.MySql;

public class ModuleBootstrapper : IModuleBootstrapper
{
    public void Bootstrap(IHostBootstrapper bootstrapper, IHostApplicationBuilder builder)
    {
        bootstrapper.Bootstrap(new LVK.Core.ModuleBootstrapper());

        bootstrapper.Bootstrap(new LVK.Data.EntityFramework.ModuleBootstrapper());
    }
}