using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;
using Domain.StaticValues;
using Infrastructure;
using Prism.Commands;
using Prism.Mvvm;
using static Domain.Exceptions.CustomException;

namespace Wpf.ViewModels
{
  internal class LatestWeatherViewModel : BindableBase
  {
    private readonly ILatestWeatherRepository _weather;
    private readonly IAreaRepository _area;
    public ObservableCollection<AreaViewModel> Areas { get; } = new();
    private CancellationTokenSource? _cancelTokenSrc;
    public static int ProgressBarValueMaximum => Shared.CacheIntervalSec;

    private LatestWeatherViewModel()
      : this(Factories.CreateLatestWeather(), Factories.CreateArea()) { }

    private LatestWeatherViewModel(ILatestWeatherRepository weather, IAreaRepository area)
    {
      _weather = weather;
      _area = area;

      foreach (AreaEntity areaData in _area.Gets())
      {
        Areas.Add(new(areaData));
      }
    }

    private DelegateCommand? _cachedSearchCommand;
    public DelegateCommand CachedSearchCommand => _cachedSearchCommand ??= new DelegateCommand(CachedSearch);

    private DelegateCommand? _searchCommand;
    public DelegateCommand SearchCommand => _searchCommand ??= new DelegateCommand(Search);

    private AreaViewModel? _selectedArea;
    public AreaViewModel? SelectedArea
    {
      get => _selectedArea;
      set => SetProperty(ref _selectedArea, value);
    }

    private bool _isCachedSearchChecked = false;
    public bool IsCachedSearchChecked
    {
      get => _isCachedSearchChecked;
      set => SetProperty(ref _isCachedSearchChecked, value);
    }

    private int _progressBarValue = 1;
    public int ProgressBarValue
    {
      get => _progressBarValue;
      set => SetProperty(ref _progressBarValue, value);
    }

    private string _measuredDate = "";
    public string MeasuredDate
    {
      get => _measuredDate;
      set => SetProperty(ref _measuredDate, value);
    }

    private string _temperature = "";
    public string Temperature
    {
      get => _temperature;
      set => SetProperty(ref _temperature, value);
    }

    private string _condition = "";
    public string Condition
    {
      get => _condition;
      set => SetProperty(ref _condition, value);
    }

    private void Search()
    {
      if (SelectedArea == null)
      {
        App.BaseExceptionProc(new CustomException("Please select Area.", ExceptionKind.Error));
      }
      else
      {
        WeatherEntity? weather = IsCachedSearchChecked ? Weathers.GetCashedWeathers(SelectedArea.ZipCode) : _weather.Search(SelectedArea.ZipCode);
        if (weather == null)
        {
          MeasuredDate = "";
          Temperature = "";
          Condition = "";
        }
        else
        {
          MeasuredDate = weather.MeasuredDate.DisplayValue;
          Temperature = weather.Temperature.DisplayValue;
          Condition = weather.Condition.DisplayValue;
        }
      }

    }

    private void CachedSearch()
    {
      if (IsCachedSearchChecked)
      {
        _ = ProgressBarWorker();
        _ = CreateCacheWorker();
      }
      else
      {
        if (_cancelTokenSrc?.IsCancellationRequested == false)
        {
          _cancelTokenSrc.Cancel();
          ProgressBarValue = 1;
        }
      }
    }

    private async Task ProgressBarWorker()
    {
      using (_cancelTokenSrc = new CancellationTokenSource())
      {
        while (!_cancelTokenSrc.Token.IsCancellationRequested)
        {
          await Task.Delay(1000, _cancelTokenSrc.Token);
          if (ProgressBarValue == Shared.CacheIntervalSec)
          {
            ProgressBarValue = 1;
          }
          else
          {
            ProgressBarValue += 1;
          }
        }
      }
    }

    private async Task CreateCacheWorker()
    {
      bool isCreatingCache = false;
      using (_cancelTokenSrc = new CancellationTokenSource())
      {
        while (!_cancelTokenSrc.Token.IsCancellationRequested)
        {
          if (isCreatingCache)
          {
            return;
          }
          try
          {
            isCreatingCache = true;
            Weathers.CreateWeathersCache(Factories.CreateWeather());
          }
          finally
          {
            isCreatingCache = false;
          }
          await Task.Delay(Shared.CacheIntervalSec * 1000, _cancelTokenSrc.Token);
        }
      }
    }
  }
}
