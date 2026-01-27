using UnitTestingPractice.Core;

[TestFixture]
public class ParameterizedTests
{
    private MathUtils _math = new();

    [TestCase(2)]
    [TestCase(4)]
    [TestCase(6)]
    public void IsEven_ReturnsTrue(int number)
        => Assert.That(_math.IsEven(number), Is.True);

    [TestCase(7)]
    [TestCase(9)]
    public void IsEven_ReturnsFalse(int number)
        => Assert.That(_math.IsEven(number), Is.False);
}
