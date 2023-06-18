using App.ViewModels;

namespace App.Views
{
  internal partial class ListView : BaseView
  {
    private readonly ListViewModel _model = new();

    internal ListView()
    {
      InitializeComponent();
      _ = WeathersDataGridView.DataBindings.Add(nameof(WeathersDataGridView.DataSource), _model, nameof(_model.Weathers));
    }
  }
}
