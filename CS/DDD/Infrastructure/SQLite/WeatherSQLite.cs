using Domain.Entities;
using Domain.Helpers;
using Domain.Repositories;
using Microsoft.Data.Sqlite;

namespace Infrastructure.SQLite
{
  public sealed class WeatherSQLite : IWeatherRepository
  {
    public WeatherEntity? GetLatest(string zipCode)
    {
      string sql =
        @"SELECT measuredDate, condition, temperature FROM Weather WHERE zipCode = @zipCode ORDER BY measuredDate DESC LIMIT 1";
      return SQLiteHelper.QuerySingle(
        sql,
        reader =>
          new WeatherEntity(
            zipCode,
            reader[nameof(WeatherEntity.MeasuredDate)].ToDateTime(),
            reader[nameof(WeatherEntity.Temperature)].ToSingle(),
            reader[nameof(WeatherEntity.Condition)].ToNotNullString()
        ),
        new List<SqliteParameter> { new SqliteParameter("@zipCode", zipCode) }.ToArray()
      );
    }
  }
}
