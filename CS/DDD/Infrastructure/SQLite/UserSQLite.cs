using Domain.Entities;
using Domain.Modules.Helpers;
using Domain.Repositories;
using Microsoft.Data.Sqlite;

namespace Infrastructure.SQLite
{
  internal sealed class UserSQLite : IUserRepository
  {
    public UserEntity? GetByName(string userName)
    {
      string sql = @"SELECT * FROM User WHERE name = @name";
      return SQLiteCore.QuerySingle(
        sql,
        reader =>
          new UserEntity(
            reader[nameof(UserEntity.ID)].ToInt(),
            reader[nameof(UserEntity.Name)].ToNotNullString(),
            reader[nameof(UserEntity.Password)].ToNotNullString(),
            reader[nameof(UserEntity.CreatedAt)].ToDateTime(),
            reader[nameof(UserEntity.UpdatedAt)].ToDateTime()
          ),
        new List<SqliteParameter> { new SqliteParameter("@name", userName) }.ToArray()
      );
    }

    public void Add(string userName, string password)
    {
      string sql = @"INSERT INTO User(name, password) VALUES(@name, @password)";
      List<SqliteParameter> args = new() { new SqliteParameter("@name", userName), new SqliteParameter("@password", password), };
      SQLiteCore.Execute(sql, args.ToArray());
    }
  }
}
