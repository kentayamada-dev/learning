using Domain.Entities;

namespace Domain.Repositories
{
  public interface IUserRepository
  {
    UserEntity? Get(string userName);
    void Add(string userName, string password);
  }
}
