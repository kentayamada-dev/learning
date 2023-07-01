using System.Collections.ObjectModel;
using Microsoft.Data.Sqlite;

namespace Infrastructure.SQLite
{
  internal sealed class SQLiteCore
  {
    private static readonly string _connectionString = @"Data Source=C:\Users\kenta\Desktop\learning\CS\DDD\DB\DDD.db";

    internal static ReadOnlyCollection<T> Query<T>(string sql, Func<SqliteDataReader, T> createEntity, SqliteParameter[]? parameters = null)
    {
      List<T> result = new();
      using SqliteConnection connection = new(_connectionString);
      using SqliteCommand command = new(sql, connection);
      connection.Open();
      if (parameters != null)
      {
        command.Parameters.AddRange(parameters);
      }
      using SqliteDataReader reader = command.ExecuteReader();
      while (reader.Read())
      {
        result.Add(createEntity(reader));
      }

      return result.AsReadOnly();
    }

    internal static T? QuerySingle<T>(string sql, Func<SqliteDataReader, T> createEntity, SqliteParameter[]? parameters = null)
    {
      using SqliteConnection connection = new(_connectionString);
      using SqliteCommand command = new(sql, connection);
      connection.Open();
      if (parameters != null)
      {
        command.Parameters.AddRange(parameters);
      }
      using SqliteDataReader reader = command.ExecuteReader();
      while (reader.Read())
      {
        return createEntity(reader);
      }
      return default;
    }

    internal static void Execute(string sql, SqliteParameter[]? parameters = null)
    {
      using SqliteConnection connection = new(_connectionString);
      using SqliteCommand command = new(sql, connection);
      connection.Open();
      if (parameters != null)
      {
        command.Parameters.AddRange(parameters);
      }
      _ = command.ExecuteNonQuery();
    }
  }
}
