using System.Collections.ObjectModel;
using Domain.Entities;

namespace Domain.Repositories
{
  public interface IAreaRepository
  {
    ReadOnlyCollection<AreaEntity> Gets();
  }
}
