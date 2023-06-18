using Domain.Entities;

namespace App.ViewModels
{
  public sealed class WeatherListViewModel
  {
    private readonly WeatherListEntity _entity;

    public WeatherListViewModel(WeatherListEntity entity)
    {
      _entity = entity;
    }

    public string ZipCode => _entity.ZipCode.Value;
    public string StateAbbr => _entity.StateAbbr.Value;
    public string MeasuredDate => _entity.MeasuredDate.DisplayValue;
    public string Condition => _entity.Condition.DisplayValue;
    public string Temperature => _entity.Temperature.DisplayValue;
  }
}
