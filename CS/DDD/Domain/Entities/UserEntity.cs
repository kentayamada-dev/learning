using Domain.ValueObjects;

namespace Domain.Entities
{
  public sealed class UserEntity
  {
    public int ID { get; }
    public string Name { get; }
    public string Password { get; }
    public CustomDateTime CreatedAt { get; }
    public CustomDateTime UpdatedAt { get; }

    public UserEntity(int id, string name, string password, DateTime createdAt, DateTime updatedAt)
    {
      ID = id;
      Name = name;
      Password = password;
      CreatedAt = new CustomDateTime(createdAt);
      UpdatedAt = new CustomDateTime(updatedAt);
    }
  }
}
