﻿using System.Collections.ObjectModel;
using Microsoft.Data.Sqlite;

namespace Infrastructure.SQLite
{
  internal class SQLiteHelper
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

    internal static void Execute(string insert, string update, SqliteParameter[]? parameters = null)
    {
      using SqliteConnection connection = new(_connectionString);
      using SqliteCommand command = new(update, connection);
      connection.Open();
      if (parameters != null)
      {
        command.Parameters.AddRange(parameters);
      }
      if (command.ExecuteNonQuery() < 1)
      {
        command.CommandText = insert;
        _ = command.ExecuteNonQuery();
      }
    }
  }
}