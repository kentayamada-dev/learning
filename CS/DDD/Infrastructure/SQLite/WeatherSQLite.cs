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

    public WeatherEntity? GetLatest(string userId, string zipCode)
    {
      string sql =
        @"SELECT zipCode, measuredDate, temperature, condition FROM Weather WHERE userId = @userId AND zipCode = @zipCode ORDER BY measuredDate DESC";

      return SQLiteCore.QuerySingle(
        sql,
        reader =>
          new WeatherEntity(
            reader[nameof(WeatherEntity.ZipCode)].ToNotNullString(),
            reader[nameof(WeatherEntity.MeasuredDate)].ToDateTime(),
            reader[nameof(WeatherEntity.Temperature)].ToSingle(),
            reader[nameof(WeatherEntity.Condition)].ToNotNullString()
          ),
        new List<SqliteParameter> { new SqliteParameter("@userId", userId), new SqliteParameter("@zipCode", zipCode) }.ToArray()
      );
    }
  }
}
