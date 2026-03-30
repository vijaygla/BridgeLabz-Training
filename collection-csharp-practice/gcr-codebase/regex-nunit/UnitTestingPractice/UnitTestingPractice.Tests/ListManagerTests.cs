using UnitTestingPractice.Core;

[TestFixture]
public class ListManagerTests
{
    private ListManager _manager = new();

    [Test]
    public void AddElement_IncreasesSize()
    {
        var list = new List<int>();
        _manager.AddElement(list, 10);
        Assert.That(list.Count, Is.EqualTo(1));
    }
}
