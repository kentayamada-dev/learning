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
        new List<SqliteParameter> { new("@userId", userId) }.ToArray()
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
        new List<SqliteParameter> { new("@userId", userId), new("@zipCode", zipCode) }.ToArray()
      );
    }

    public void Edit(WeatherEntity weather, string userId)
    {
      string sql =
        @"INSERT OR REPLACE INTO Weather(zipCode, measuredDate, condition, temperature, userId) VALUES(@zipCode, @measuredDate, @condition, @temperature, @userId)";

      List<SqliteParameter> args =
        new()
        {
          new("@zipCode", weather.ZipCode.DisplayValue),
          new("@measuredDate", weather.MeasuredDate.DisplayValue),
          new("@condition", weather.Condition.Value),
          new("@temperature", weather.Temperature.Value),
          new("@userId", userId)
        };
      SQLiteCore.Execute(sql, args.ToArray());
    }

    public ReadOnlyCollection<WeatherEntity> GetLatestList(string userId)
    {
      string sql =
        @"SELECT w1.zipCode, w1.measuredDate, w1.condition, w1.temperature FROM Weather w1 WHERE w1.measuredDate = (SELECT MAX(w2.measuredDate) FROM Weather w2 WHERE w2.zipCode = w1.zipCode AND w2.userId = @userId)";
      return SQLiteCore.Query(
        sql,
        reader =>
          new WeatherEntity(
            reader[nameof(WeatherEntity.ZipCode)].ToNotNullString(),
            reader[nameof(WeatherEntity.MeasuredDate)].ToDateTime(),
            reader[nameof(WeatherEntity.Temperature)].ToSingle(),
            reader[nameof(WeatherEntity.Condition)].ToNotNullString()
          ),
        new List<SqliteParameter> { new("@userId", userId) }.ToArray()
      );
    }
  }
}
