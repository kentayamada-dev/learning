using WinForms.ViewModels;

namespace WinForms.Views
{
  internal partial class WeatherEditorView : BaseView
  {
    private readonly WeatherEditorViewModel _model = new();

    internal WeatherEditorView()
    {
      InitializeComponent();
      _ = StateComboBox.ValueMember = nameof(AreaViewModel.ZipCode);
      _ = StateComboBox.DisplayMember = nameof(AreaViewModel.StateAbbr);
      _ = StateComboBox.DataBindings.Add(nameof(StateComboBox.SelectedValue), _model, nameof(_model.SelectedZipCode));
      _ = StateComboBox.DataBindings.Add(nameof(StateComboBox.DataSource), _model, nameof(_model.Areas));
      _ = MeasuredDateDateTimePicker.DataBindings.Add(nameof(MeasuredDateDateTimePicker.Value), _model, nameof(_model.MeasuredDate));
      _ = ConditionComboBox.ValueMember = nameof(ConditionViewModel.Value);
      _ = ConditionComboBox.DisplayMember = nameof(ConditionViewModel.DisplayValue);
      _ = ConditionComboBox.DataBindings.Add(nameof(ConditionComboBox.SelectedValue), _model, nameof(_model.SelectedCondition));
      _ = ConditionComboBox.DataBindings.Add(nameof(ConditionComboBox.DataSource), _model, nameof(_model.Conditions));
      _ = TemperatureNumericUpDown.DataBindings.Add(nameof(TemperatureNumericUpDown.Text), _model, nameof(_model.TemperatureValue));
      _ = UnitLabel.DataBindings.Add(nameof(UnitLabel.Text), _model, nameof(_model.TemperatureUnit));
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      _model.Save();
      Close();
    }
  }
}
