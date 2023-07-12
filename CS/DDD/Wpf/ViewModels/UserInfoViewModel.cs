using Domain;
using Prism.Mvvm;

namespace Wpf.ViewModels
{
  internal class UserInfoViewModel : BindableBase
  {
    private UserInfoViewModel()
    {
      ID = Shared.CurrentUser.ID.DisplayValue;
      Name = Shared.CurrentUser.Name.DisplayValue;
      Password = Shared.CurrentUser.Password.DisplayValue;
      CreatedAt = Shared.CurrentUser.CreatedAt.DisplayValue;
      UpdatedAt = Shared.CurrentUser.UpdatedAt.DisplayValue;
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
