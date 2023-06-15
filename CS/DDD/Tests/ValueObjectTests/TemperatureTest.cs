using Domain.ValueObjects;

namespace Tests.ValueObjectTests
{
  [TestClass]
  public class TemperatureTest
  {
    private readonly Temperature _one = new(30.2f);
    private readonly Temperature _two = new(30.2f);
    private readonly Temperature _three = new(20f);

    [TestMethod]
    public void Equal()
    {
      Assert.AreEqual(true, EqualityComparer<Temperature>.Default.Equals(_one, _two));
      Assert.AreEqual(true, Equals(_one, _two));
      Assert.AreEqual(true, _one.Equals(_two));
      Assert.AreEqual(true, _one == _two);

      Assert.AreEqual(false, EqualityComparer<Temperature>.Default.Equals(_one, _three));
      Assert.AreEqual(false, Equals(_one, _three));
      Assert.AreEqual(false, _one.Equals(_three));
      Assert.AreEqual(false, _one == _three);
    }

    [TestMethod]
    public void HashCode()
    {
      Assert.AreEqual(true, _one.GetHashCode() == _two.GetHashCode());
      Assert.AreEqual(false, _one.GetHashCode() == _three.GetHashCode());
    }

    [TestMethod]
    public void DisplayValue()
    {
      Assert.AreEqual("30.2℃", _one.DisplayValue);
      Assert.AreEqual("20.0℃", _three.DisplayValue);
    }
  }
}
