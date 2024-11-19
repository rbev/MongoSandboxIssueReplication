using MongoSandbox;
using NUnit.Framework;

namespace MongoSandboxIssueReplication;

public class Test
{
    [Test]
    public void TestConstructor()
    {
        var db = MongoRunner.Run();
        
        Assert.Pass("Wooooo, it worked");
    }
}
