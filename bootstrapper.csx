// #load "api.index.csx"

using Autofac;
// using Autofac.Core.Lifetime;
// using Nancy.Bootstrapper;
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
