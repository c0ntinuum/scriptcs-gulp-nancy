using Nancy;

public class IndexModule : NancyModule
{
    public IndexModule()
    {
        Get["/", true] = async (x, ct) =>
        {
            return await Task.FromResult<string>("Hello, world!");
        };
    }
}
