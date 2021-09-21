using NUnit.Framework;

[TestFixture]
public class UnitTestServiceTests
{
    [Test]
    [TestCase(true, false)]
    [TestCase(false, true)]
    public void GetInvertedBool_WithBool_ReturnsInvertedBool(bool input, bool expected)
    {
        bool result = UnitTestService.GetInverted(input);

        Assert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(0, 0)]
    [TestCase(10, -10)]
    [TestCase(-10, 10)]
    public void GetInvertedInt_WithInt_ReturnsInvertedInt(int input, int expected)
    {
        int result = UnitTestService.GetInverted(input);

        Assert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(0f, 0f)]
    [TestCase(10f, -10f)]
    [TestCase(-10f, 10f)]
    [TestCase(-0.10f, 0.10f)]
    [TestCase(-1.5f, 1.5f)]
    public void GetInvertedFloat_WithFloat_ReturnsInvertedFloat(float input, float expected)
    {
        float result = UnitTestService.GetInverted(input);

        Assert.AreEqual(expected, result);
    }
}
