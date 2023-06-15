using Domain.ValueObjects;

namespace Tests.ValueObjectTests
{
  [TestClass]
  public class ZipCodeTest
  {
    private readonly ZipCode _one = new("12345");

    [TestMethod]
    public void ZipCode()
    {
      Assert.AreEqual("12345", _one.Value);
    }
  }
}
