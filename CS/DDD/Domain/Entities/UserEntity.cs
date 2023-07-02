using Domain.ValueObjects;

namespace Domain.Entities
{
  public sealed class UserEntity : AuthUserEntity
  {
    public Any<int> ID { get; }
    public CustomDateTime CreatedAt { get; }
    public CustomDateTime UpdatedAt { get; }

    public UserEntity(int id, string name, string password, DateTime createdAt, DateTime updatedAt)
      : base(name, password)
    {
      ID = new(id);
      CreatedAt = new(createdAt);
      UpdatedAt = new(updatedAt);
    }
  }
}
