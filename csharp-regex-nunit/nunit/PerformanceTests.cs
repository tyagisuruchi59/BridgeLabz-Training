using NUnit.Framework;
using System.Threading;

public class PerformanceTask
{
    public void LongRunningTask()
    {
        Thread.Sleep(3000);
    }
}

[TestFixture]
public class PerformanceTests
{
    [Test]
    [Timeout(2000)]
    public void LongRunningTask_Test()
    {
        new PerformanceTask().LongRunningTask();
    }
}
