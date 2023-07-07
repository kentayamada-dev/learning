using Domain.Entities;

namespace Wpf.ViewModels
{
  internal sealed class AreaViewModel
  {
    private readonly AreaEntity _entity;

    internal AreaViewModel(AreaEntity entity)
    {
      _entity = entity;
    }

    public string ZipCode => _entity.ZipCode.Value;
    public string StateAbbr => _entity.StateAbbr.Value;
  }
}
