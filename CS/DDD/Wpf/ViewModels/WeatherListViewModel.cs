using Domain.Entities;

namespace Wpf.ViewModels
{
  internal sealed class WeatherListViewModel
  {
    private readonly WeatherListEntity _entity;

    internal WeatherListViewModel(WeatherListEntity entity)
    {
      _entity = entity;
    }

    public string ZipCode => _entity.ZipCode.DisplayValue;
    public string StateAbbr => _entity.StateAbbr.DisplayValue;
    public string MeasuredDate => _entity.MeasuredDate.DisplayValue;
    public string Condition => _entity.Condition.DisplayValue;
    public string Temperature => _entity.Temperature.DisplayValue;
  }
}
