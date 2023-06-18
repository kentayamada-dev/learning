using System.Collections.ObjectModel;
using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class AreaFake : IAreaRepository
  {
    public ReadOnlyCollection<AreaEntity> GetData()
    {
      try
      {
        string fakeAreasPath = Shared.FakeAreasPath ?? throw new Exception("FakeAreasPath not specified in config file.");
        string[] lines = File.ReadAllLines(fakeAreasPath);
        List<AreaEntity> Areas = new();
        foreach (string line in lines)
        {
          string[] value = line.Split(",");
          Areas.Add(new AreaEntity(value[0], value[1]));
        }
        ;

        return Areas.AsReadOnly();
      }
      catch (Exception Exception)
      {
        throw new FakeException("Exception Occurred.", Exception);
      }
    }
  }
}
