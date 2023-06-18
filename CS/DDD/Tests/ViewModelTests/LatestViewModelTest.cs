using System.Collections.ObjectModel;
using App.ViewModels;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Modules.Helpers;
using Domain.Repositories;
using Moq;

namespace Tests.ViewModelTests
{
  [TestClass]
  public class LatestViewModelTest
  {
    [TestMethod]
    public void Scenario()
    {
      ReadOnlyCollection<AreaEntity> Areas = new List<AreaEntity>() { new AreaEntity("35004", "AL"), new AreaEntity("20003", "CA") }.AsReadOnly();
      Mock<IAreaRepository> AreaMock = new();
      _ = AreaMock.Setup(x => x.GetData()).Returns(Areas);
      Mock<IWeatherRepository> WeatherMock = new();

      WeatherEntity Weather = new("35004", "2018-08-11 11:10:10".ToDateTime(), 12.351f, "SUNNY");
      _ = WeatherMock.Setup(x => x.GetLatest("35004")).Returns(Weather);

      LatestViewModel Model = new(WeatherMock.Object, AreaMock.Object);

      Assert.AreEqual("", Model.SelectedZipCode);
      Assert.AreEqual("", Model.MeasuredDate);
      Assert.AreEqual("", Model.Condition);
      Assert.AreEqual("", Model.Temperature);

      Model.SelectedZipCode = "35004";
      Model.Search(false);
      Assert.AreEqual("35004", Model.SelectedZipCode);
      Assert.AreEqual("2018-08-11 11:10:10", Model.MeasuredDate);
      Assert.AreEqual("Sunny", Model.Condition);
      Assert.AreEqual("12.4℃", Model.Temperature);

      Model.SelectedZipCode = "20003";
      DataNotExistsException Ex = Assert.ThrowsException<DataNotExistsException>(() => Model.Search(true));
      Assert.AreEqual("Data Does Not Exists.", Ex.Message);
      Assert.AreEqual("20003", Model.SelectedZipCode);
      Assert.AreEqual("", Model.MeasuredDate);
      Assert.AreEqual("", Model.Condition);
      Assert.AreEqual("", Model.Temperature);
    }
  }
}
