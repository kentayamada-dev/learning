using Domain.Entities;

namespace Domain.Repositories
{
  public interface IUserRepository
  {
    UserEntity? GetByName(string userName);
    void Add(string userName, string password);
  }
}
