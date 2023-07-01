using Domain.ValueObjects;

namespace Domain.Entities
{
  public sealed class UserEntity
  {
    public Any<int> ID { get; }
    public Name Name { get; }
    public Password Password { get; }
    public CustomDateTime CreatedAt { get; }
    public CustomDateTime UpdatedAt { get; }

    public UserEntity(int id, string name, string password, DateTime createdAt, DateTime updatedAt)
    {
      ID = new Any<int>(id);
      Name = new Name(name);
      Password = new Password(password);
      CreatedAt = new CustomDateTime(createdAt);
      UpdatedAt = new CustomDateTime(updatedAt);
    }
  }
}
