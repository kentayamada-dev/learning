using Domain.Modules.Helpers;
using Domain.ValueObjects;

namespace Tests.ValueObjectTests
{
  [TestClass]
  public class MeasuredDateTest
  {
    private readonly MeasuredDate _one = new("2018-08-10 11:10:10".ToDateTime());

    [TestMethod]
    public void DateTime()
    {
      Assert.AreEqual("2018-08-10 11:10:10", _one.DisplayValue);
    }
  }
}
