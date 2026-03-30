[TestFixture]
public class PerformanceTests
{
    [Test]
    [CancelAfter(2000)]
    public void LongRunningTask_FailsOnTimeout()
    {
        Thread.Sleep(3000);
    }
}
