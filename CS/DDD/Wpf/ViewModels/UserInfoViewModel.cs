using Domain;
using Domain.Exceptions;
using Prism.Mvvm;
using static Domain.Exceptions.CustomException;

namespace Wpf.ViewModels
{
  internal class UserInfoViewModel : BindableBase
  {
    private UserInfoViewModel()
    {
      Domain.Entities.UserEntity? currentUser = Shared.User;
      if (currentUser == null)
      {
        App.BaseExceptionProc(new CustomException($"User not authorized.", ExceptionKind.Error));
      }
      else
      {
        _id = currentUser.ID.DisplayValue;
        _name = currentUser.Name.DisplayValue;
        _password = currentUser.Password.DisplayValue;
        _createdAt = currentUser.CreatedAt.DisplayValue;
        _updatedAt = currentUser.UpdatedAt.DisplayValue;
      }
    }

    private string _id = "";
    public string ID
    {
      get => _id;
      set => SetProperty(ref _id, value);
    }

    private string _name = "";
    public string Name
    {
      get => _name;
      set => SetProperty(ref _name, value);
    }

    private string _password = "";
    public string Password
    {
      get => _password;
      set => SetProperty(ref _password, value);
    }

    private string _createdAt = "";
    public string CreatedAt
    {
      get => _createdAt;
      set => SetProperty(ref _createdAt, value);
    }

    private string _updatedAt = "";
    public string UpdatedAt
    {
      get => _updatedAt;
      set => SetProperty(ref _updatedAt, value);
    }
  }
}
