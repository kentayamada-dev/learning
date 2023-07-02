using Domain.ValueObjects;

namespace Domain.Entities
{
  public class AuthUserEntity
  {
    public Name Name { get; }
    public Password Password { get; }

    public AuthUserEntity(string name, string password)
    {
      Name = new(name);
      Password = new(password);
    }
  }
}
