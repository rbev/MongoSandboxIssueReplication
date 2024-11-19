using MongoSandbox;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MongoSandboxIssueReplication;

[Binding]
public class SampleSteps
{
    [When(@"specflow starts a MongoSandbox")]
    public async Task WhenSpecflowStartsAMongoSandbox()
    {
        await Task.Delay(200);
        using var db = MongoRunner.Run(new MongoRunnerOptions()
        {
            UseSingleNodeReplicaSet = true
        });
    }

    [Then(@"the MongoSandbox is started")]
    public void ThenTheMongoSandboxIsStarted()
    {
        Assert.Pass();
    }
}