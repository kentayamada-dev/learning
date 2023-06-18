using System.Collections.ObjectModel;
using Domain.Entities;
using Domain.Helpers;
using Domain.Repositories;

namespace Infrastructure.SQLite
{
  public sealed class AreaSQLite : IAreaRepository
  {
    public ReadOnlyCollection<AreaEntity> GetData()
    {
      string sql = @"SELECT * FROM Area";
      return SQLiteHelper.Query(
        sql,
        reader => new AreaEntity(reader[nameof(AreaEntity.ZipCode)].ToNotNullString(), reader[nameof(AreaEntity.StateAbbr)].ToNotNullString())
      );
    }
  }
}
