using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace CardDeckGame.Test;

public class UnitTest1 : IDisposable
{
    protected TestServer _testServer;
    public UnitTest1()
    {
        var webBuilder = new WebHostBuilder();
        webBuilder.UseStartup<Program>();

        _testServer = new TestServer(webBuilder);
    }

    [Fact]
    public void Test1()
    {

    }






    public void Dispose()
    {
        _testServer.Dispose();
    }
}