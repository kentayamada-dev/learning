using Domain;
using WinForms.BackgroundWorkers;
using WinForms.ViewModels;

namespace WinForms.Views
{
  internal partial class LatestWeatherView : BaseView
  {
    private readonly LatestWeatherViewModel _model = new();
    private int _count = 0;

    internal LatestWeatherView()
    {
      InitializeComponent();
      _ = ZipCodeComboBox.ValueMember = nameof(AreaViewModel.ZipCode);
      _ = ZipCodeComboBox.DisplayMember = nameof(AreaViewModel.StateAbbr);
      _ = ZipCodeComboBox.DataBindings.Add(nameof(ZipCodeComboBox.SelectedValue), _model, nameof(_model.SelectedZipCode));
      _ = ZipCodeComboBox.DataBindings.Add(nameof(ZipCodeComboBox.DataSource), _model, nameof(_model.Areas));
      _ = MeasuredDateTextBox.DataBindings.Add(nameof(MeasuredDateTextBox.Text), _model, nameof(_model.MeasuredDate));
      _ = ConditionTextBox.DataBindings.Add(nameof(ConditionTextBox.Text), _model, nameof(_model.Condition));
      _ = TemperatureTextBox.DataBindings.Add(nameof(TemperatureTextBox.Text), _model, nameof(_model.Temperature));
      CachedSearchProgressBar.Maximum = Shared.CacheIntervalSec - 1;
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
      try
      {
        _model.Search();
      }
      catch (Exception Ex)
      {
        BaseExceptionProc(Ex);
      }
    }

    private void ListButton_Click(object sender, EventArgs e)
    {
      using WeatherListView WeatherListView = new();
      _ = WeatherListView.ShowDialog();
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
      using WeatherEditorView WeatherEditorView = new();
      _ = WeatherEditorView.ShowDialog();
    }

    private void CachedSearchCheckBox_Click(object sender, EventArgs e)
    {
      if (((CheckBox)sender).CheckState == CheckState.Checked)
      {
        if (!WeathersCachingWorker.IsWeathersCachingWorkerRunning)
        {
          WeathersCachingWorker.Start();
        }
      }
      else
      {
        if (WeathersCachingWorker.IsWeathersCachingWorkerRunning)
        {
          WeathersCachingWorker.Stop();
        }
      }
    }

    private void CachedSearchTimer_Tick(object sender, EventArgs e)
    {
      if (WeathersCachingWorker.IsWeathersCachingWorkerRunning)
      {
        CachedSearchProgressBar.Value = _count;
        _count += 1;
        if (_count % Shared.CacheIntervalSec == 0)
        {
          _count = 0;
        }
      }
      else
      {
        CachedSearchProgressBar.Value = 0;
      }
    }
  }
}
