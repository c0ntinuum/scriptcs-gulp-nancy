#load "bootstrapper.csx"

using System.Threading;
using Nancy;
using Nancy.Hosting.Self;

NancyBootstrapperLocator.Bootstrapper = new Bootstrapper();

var address = "http://localhost:1234/";

using (var host = new NancyHost(new Uri(address)))
{
  host.Start();
  Console.WriteLine("Nancy is running at: " + address);
  Thread.Sleep(1000);
  // host.Stop();
}
