using App.ViewModels;

namespace App.Views
{
  internal partial class LatestView : BaseView
  {
    private readonly LatestViewModel _model = new();

    internal LatestView()
    {
      InitializeComponent();
      _ = ZipCodeComboBox.ValueMember = nameof(AreaViewModel.ZipCode);
      _ = ZipCodeComboBox.DisplayMember = nameof(AreaViewModel.StateAbbr);
      _ = ZipCodeComboBox.DataBindings.Add(nameof(ZipCodeComboBox.SelectedValue), _model, nameof(_model.SelectedZipCode));
      _ = ZipCodeComboBox.DataBindings.Add(nameof(ZipCodeComboBox.DataSource), _model, nameof(_model.Areas));
      _ = MeasuredDateTextBox.DataBindings.Add(nameof(MeasuredDateTextBox.Text), _model, nameof(_model.MeasuredDate));
      _ = ConditionTextBox.DataBindings.Add(nameof(ConditionTextBox.Text), _model, nameof(_model.Condition));
      _ = TemperatureTextBox.DataBindings.Add(nameof(TemperatureTextBox.Text), _model, nameof(_model.Temperature));
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
      try
      {
        _model.Search(CachedSearchCheckBox.Checked);
      }
      catch (Exception Ex)
      {
        BaseExceptionProc(Ex);
      }
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
      using EditView EditView = new();
      _ = EditView.ShowDialog();
    }

    private void ListButton_Click(object sender, EventArgs e)
    {
      using ListView ListView = new();
      _ = ListView.ShowDialog();
    }
  }
}
