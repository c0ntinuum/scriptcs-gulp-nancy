#load "api.index.csx"

using Autofac;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.Autofac;

public class Bootstrapper : AutofacNancyBootstrapper {}


//   protected override IEnumerable<ModuleRegistration> Modules
//   {
//     get
//     {
//       return new []
//       {
//         new ModuleRegistration(typeof(Index2), typeof(Index2).FullName)
//       };
//     }
//   }
// }
