using App.ViewModels;
using Domain.Entities;
using Domain.Helpers;
using Domain.Repositories;
using Moq;

namespace Tests.ViewModelTests;

[TestClass]
public class LatestViewModelTest
{
  [TestMethod]
  public void Scenario()
  {
    WeatherEntity Entity = new("35004", "2018-08-10 11:10:10".ToDateTime(), 12.341f, "SUNNNY");
    Mock<IWeatherRepository> Mock = new();
    _ = Mock.Setup(x => x.GetLatest()).Returns(Entity);
    LatestViewModel Model = new(Mock.Object);

    Model.Search();

    Assert.AreEqual("35004", Model.ZipCode);
    Assert.AreEqual("2018-08-10 11:10:10", Model.MeasuredDate);
    Assert.AreEqual("12.34℃", Model.Temperature);
    Assert.AreEqual("Sunny", Model.Condition);
  }
}
