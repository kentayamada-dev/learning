using WinForms.ViewModels;

namespace WinForms.Views
{
  internal partial class WeatherListView : BaseView
  {
    private readonly WeathersListViewModel _model = new();

    internal WeatherListView()
    {
      InitializeComponent();
      _ = WeathersListGridView.DataBindings.Add(nameof(WeathersListGridView.DataSource), _model, nameof(_model.Weathers));
    }
  }
}
