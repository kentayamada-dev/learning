using Domain.ValueObjects;

namespace Domain.Entities
{
  public sealed class UserEntity
  {
    public ID ID { get; }
    public Name Name { get; }
    public Password Password { get; }
    public CustomDateTime CreatedAt { get; }
    public CustomDateTime UpdatedAt { get; }

    public UserEntity(int? id, string? name, string? password, DateTime? createdAt, DateTime? updatedAt)
    {
      ID = new(id);
      Name = new(name);
      Password = new(password);
      CreatedAt = new(createdAt, $"{CreatedAt}");
      UpdatedAt = new(updatedAt, $"{UpdatedAt}");
    }
  }
}
