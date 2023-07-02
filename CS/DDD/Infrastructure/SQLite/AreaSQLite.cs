using System.Collections.ObjectModel;
using Domain.Entities;
using Domain.Modules.Helpers;
using Domain.Repositories;

namespace Infrastructure.SQLite
{
  internal sealed class AreaSQLite : IAreaRepository
  {
    public ReadOnlyCollection<AreaEntity> Gets()
    {
      string sql = @"SELECT * FROM Area";

      return SQLiteCore.Query(
        sql,
        reader => new AreaEntity(reader[nameof(AreaEntity.ZipCode)].ToNotNullString(), reader[nameof(AreaEntity.StateAbbr)].ToNotNullString())
      );
    }
  }
}
