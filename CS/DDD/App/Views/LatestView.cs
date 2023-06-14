using App.ViewModels;

namespace App.Views
{
  internal partial class LatestView : BaseView
  {
    private readonly LatestViewModel _model = new();

    internal LatestView()
    {
      InitializeComponent();
      _ = ZipCodeTextBox.DataBindings.Add(nameof(ZipCodeTextBox.Text), _model, nameof(_model.ZipCode));
      _ = MeasuredDateTextBox.DataBindings.Add(nameof(ZipCodeTextBox.Text), _model, nameof(_model.MeasuredDate));
      _ = ConditionTextBox.DataBindings.Add(nameof(ZipCodeTextBox.Text), _model, nameof(_model.Condition));
      _ = TemperatureTextBox.DataBindings.Add(nameof(ZipCodeTextBox.Text), _model, nameof(_model.Temperature));
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
      _model.Search();
    }
  }
}
