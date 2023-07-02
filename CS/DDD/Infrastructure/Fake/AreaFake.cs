using System.Collections.ObjectModel;
using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class AreaFake : IAreaRepository
  {
    public ReadOnlyCollection<AreaEntity> Gets()
    {
      string fakeAreaPath =
        Shared.FakeAreasPath
        ?? throw new CustomException($"{nameof(Shared.FakeAreasPath)} not specified in appsettings.json.", CustomException.ExceptionKind.Error);
      List<AreaEntity> areas = new();
      foreach (string line in File.ReadAllLines(fakeAreaPath))
      {
        string[] value = line.Split(",");
        areas.Add(new AreaEntity(value[0], value[1]));
      }
      return areas.AsReadOnly();
    }
  }
}
