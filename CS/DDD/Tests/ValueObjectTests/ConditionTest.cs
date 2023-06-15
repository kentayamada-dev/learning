using System.Collections.ObjectModel;
using Domain.ValueObjects;

namespace Tests.ValueObjectTests
{
  [TestClass]
  public class ConditionTest
  {
    private readonly Condition _sunny = new("SUNNY");
    private readonly Condition _cloudy = new("CLOUDY");
    private readonly Condition _rainy = new("RAINY");
    private readonly Condition _unknown = new("UNKNOWN");

    [TestMethod]
    public void Conditions()
    {
      Assert.AreEqual("Sunny", _sunny.DisplayValue);
      Assert.AreEqual("Cloudy", _cloudy.DisplayValue);
      Assert.AreEqual("Rainy", _rainy.DisplayValue);
      Assert.AreEqual("Unknown", _unknown.DisplayValue);

      Assert.AreEqual("SUNNY", Condition.Sunny.Value);
      Assert.AreEqual("Sunny", Condition.Sunny.DisplayValue);
      Assert.AreEqual("CLOUDY", Condition.Cloudy.Value);
      Assert.AreEqual("Cloudy", Condition.Cloudy.DisplayValue);
      Assert.AreEqual("RAINY", Condition.Rainy.Value);
      Assert.AreEqual("Rainy", Condition.Rainy.DisplayValue);
      Assert.AreEqual("UNKNOWN", Condition.Unknown.Value);
      Assert.AreEqual("Unknown", Condition.Unknown.DisplayValue);
    }

    [TestMethod]
    public void ConditionList()
    {
      ReadOnlyCollection<Condition> Conditions = Condition.ToList();
      Assert.AreEqual(4, Conditions.Count);
      Assert.AreEqual("SUNNY", Conditions[0].Value);
      Assert.AreEqual("Sunny", Conditions[0].DisplayValue);
    }
  }
}
