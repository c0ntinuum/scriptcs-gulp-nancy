// #load "api.index.csx"

using Autofac;
using Nancy.Bootstrappers.Autofac;

public class Bootstrapper : AutofacNancyBootstrapper
{
    private readonly ILifetimeScope _lifetimeScope;

    public Bootstrapper(ILifetimeScope lifetimeScope)
    {
        _lifetimeScope = lifetimeScope;
    }

    protected override ILifetimeScope GetApplicationContainer()
    {
        return _lifetimeScope;
    }
}
