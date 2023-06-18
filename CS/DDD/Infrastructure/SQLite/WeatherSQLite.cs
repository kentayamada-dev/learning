using System.Collections.ObjectModel;
using Domain.Entities;
using Domain.Helpers;
using Domain.Repositories;
using Microsoft.Data.Sqlite;

namespace Infrastructure.SQLite
{
  public sealed class WeatherSQLite : IWeatherRepository
  {
    public void Edit(WeatherEntity weather)
    {
      string insert = @"INSERT INTO Weather(zipCode, measuredDate, condition, temperature) VALUES(@zipCode, @measuredDate, @condition, @temperature)";
      string update = @"UPDATE Weather SET condition=@condition, temperature=@temperature WHERE zipCode=@zipCode AND measuredDate=@measuredDate";
      List<SqliteParameter> args =
        new()
        {
          new SqliteParameter("@zipCode", weather.ZipCode.Value),
          new SqliteParameter("@measuredDate", weather.MeasuredDate.DisplayValue),
          new SqliteParameter("@condition", weather.Condition.Value),
          new SqliteParameter("@temperature", weather.Temperature.Value),
        };
      SQLiteHelper.Execute(insert, update, args.ToArray());
    }

    public ReadOnlyCollection<WeatherListEntity> GetData()
    {
      string sql = @"SELECT * FROM Area INNER JOIN Weather ON Area.zipCode = Weather.zipCode ORDER BY MeasuredDate DESC";
      return SQLiteHelper.Query(
        sql,
        reader =>
          new WeatherListEntity(
            reader[nameof(WeatherListEntity.ZipCode)].ToNotNullString(),
            reader[nameof(WeatherListEntity.MeasuredDate)].ToDateTime(),
            reader[nameof(WeatherListEntity.Temperature)].ToSingle(),
            reader[nameof(WeatherListEntity.Condition)].ToNotNullString(),
            reader[nameof(WeatherListEntity.StateAbbr)].ToNotNullString()
          )
      );
    }

    public WeatherEntity? GetLatest(string zipCode)
    {
      string sql = @"SELECT measuredDate, condition, temperature FROM Weather WHERE zipCode = @zipCode ORDER BY measuredDate DESC LIMIT 1";
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

    public ReadOnlyCollection<WeatherEntity> GetLatestList()
    {
      string sql =
        @"SELECT Weather.zipCode, Weather.measuredDate, Weather.condition, Weather.temperature FROM Weather INNER JOIN (SELECT zipCode, MAX(measuredDate) AS maxDate FROM Weather GROUP BY zipCode) AS subquery ON Weather.zipCode = subquery.zipCode AND Weather.measuredDate = subquery.maxDate";
      return SQLiteHelper.Query(
        sql,
        reader =>
          new WeatherEntity(
            reader[nameof(WeatherEntity.ZipCode)].ToNotNullString(),
            reader[nameof(WeatherEntity.MeasuredDate)].ToDateTime(),
            reader[nameof(WeatherEntity.Temperature)].ToSingle(),
            reader[nameof(WeatherEntity.Condition)].ToNotNullString()
          )
      );
    }
  }
}
