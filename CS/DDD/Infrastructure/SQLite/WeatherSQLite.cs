using System.Collections.ObjectModel;
using Domain.Entities;
using Domain.Modules.Helpers;
using Domain.Repositories;
using Microsoft.Data.Sqlite;

namespace Infrastructure.SQLite
{
  internal sealed class WeatherSQLite : IWeatherRepository
  {
    public ReadOnlyCollection<WeatherListEntity> Gets(int? userId)
    {
      string sql =
        @"SELECT Weather.zipCode, Weather.measuredDate, Weather.condition, Weather.temperature, Area.stateAbbr FROM Weather JOIN Area ON Weather.zipCode = Area.zipCode WHERE Weather.userId = @userId ORDER BY Weather.measuredDate DESC";

      return SQLiteCore.Query(
        sql,
        reader =>
          new WeatherListEntity(
            reader[nameof(WeatherListEntity.ZipCode)].ToNotNullString(),
            reader[nameof(WeatherListEntity.MeasuredDate)].ToDateTime(),
            reader[nameof(WeatherListEntity.Temperature)].ToSingle(),
            reader[nameof(WeatherListEntity.Condition)].ToNotNullString(),
            reader[nameof(WeatherListEntity.StateAbbr)].ToNotNullString()
          ),
        new List<SqliteParameter> { new SqliteParameter("@userId", userId) }.ToArray()
      );
    }
  }
}
