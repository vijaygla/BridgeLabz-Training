using UnitTestingPractice.Core;

[TestFixture]
public class StringUtilsTests
{
    private StringUtils _utils = new();

    [Test]
    public void IsPalindrome_ReturnsTrue()
        => Assert.That(_utils.IsPalindrome("madam"), Is.True);
}
