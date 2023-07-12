using System;
using System.Collections.ObjectModel;
using System.Linq;
using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;
using Domain.ValueObjects;
using Infrastructure;
using Prism.Commands;
using Prism.Mvvm;
using static Domain.Exceptions.CustomException;

namespace Wpf.ViewModels
{
  internal class WeatherViewModel : BindableBase
  {
    private readonly IWeatherEditorRepository _weatherEditor;
    private readonly IWeatherRepository _weather;
    private readonly IAreaRepository _area;
    public ObservableCollection<WeatherListViewModel> Weathers { get; } = new();
    public ObservableCollection<ConditionViewModel> Conditions { get; } = new();
    public ObservableCollection<AreaViewModel> Areas { get; } = new();

    internal WeatherViewModel()
      : this(Factories.CreateWeatherEditor(), Factories.CreateWeather(), Factories.CreateArea()) { }

    private WeatherViewModel(IWeatherEditorRepository weatherEditor, IWeatherRepository weather, IAreaRepository area)
    {
      _weatherEditor = weatherEditor;
      _weather = weather;
      _area = area;
      foreach (AreaEntity areaData in _area.Gets())
      {
        Areas.Add(new(areaData));
      }

      foreach (Condition conditionData in Condition.ToList())
      {
        Conditions.Add(new(conditionData));
      }

      foreach (WeatherListEntity entity in _weather.Gets(Shared.CurrentUser.ID.Value))
      {
        Weathers.Add(new(entity));
      }
    }

    public AreaViewModel? SelectedArea { get; set; }
    public ConditionViewModel? SelectedCondition { get; set; }
    private DateTime _measuredDate = DateTime.Now;
    public DateTime MeasuredDate
    {
      get => _measuredDate;
      set => SetProperty(ref _measuredDate, value);
    }
    private float _temperatureValue = 0;
    public float TemperatureValue
    {
      get => _temperatureValue;
      set => SetProperty(ref _temperatureValue, value);
    }
    public string TemperatureUnit { get; } = Temperature.Unit;
    private DelegateCommand? _resetCommand;
    public DelegateCommand ResetCommand => _resetCommand ??= new DelegateCommand(Reset);
    private DelegateCommand? _saveCommand;
    public DelegateCommand SaveCommand => _saveCommand ??= new DelegateCommand(Save);
    private DelegateCommand<WeatherListViewModel>? _editWeatherCommand;
    public DelegateCommand<WeatherListViewModel> EditWeatherCommand => _editWeatherCommand ??= new DelegateCommand<WeatherListViewModel>(EditWeather);
    private int _selectedIndex = 0;
    public int SelectedIndex
    {
      get => _selectedIndex;
      set => SetProperty(ref _selectedIndex, value);
    }
    private string _selectedAreaValue = "";
    public string SelectedAreaValue
    {
      get => _selectedAreaValue;
      set => SetProperty(ref _selectedAreaValue, value);
    }
    private string _selectedConditionValue = "";
    public string SelectedConditionValue
    {
      get => _selectedConditionValue;
      set => SetProperty(ref _selectedConditionValue, value);
    }

    internal void Save()
    {
      if (SelectedArea == null)
      {
        App.BaseExceptionProc(new CustomException("Please select Area.", ExceptionKind.Error));
      }
      else if (SelectedCondition == null)
      {
        App.BaseExceptionProc(new CustomException("Please select Condition.", ExceptionKind.Error));
      }
      else
      {
        try
        {
          _weatherEditor.Edit(SelectedArea?.ZipCode, MeasuredDate, TemperatureValue, SelectedCondition?.Value);
          WeatherListEntity newWeather = new(SelectedArea?.ZipCode, MeasuredDate, TemperatureValue, SelectedCondition?.Value, SelectedArea?.StateAbbr);
          WeatherListViewModel? oldWeather = Weathers.FirstOrDefault(
            weather => weather.ZipCode == SelectedArea?.ZipCode && weather.MeasuredDateValue == MeasuredDate
          );
          if (oldWeather == null)
          {
            Weathers.Insert(0, new(newWeather));
            throw new CustomException("Weather Added.", ExceptionKind.Information);
          }
          else
          {
            int index = Weathers.IndexOf(oldWeather);
            Weathers[index] = new(newWeather);
            throw new CustomException("Weather Updated.", ExceptionKind.Information);
          }
        }
        catch (Exception Ex)
        {
          App.BaseExceptionProc(Ex);
        }
      }
    }

    private void Reset()
    {
      SelectedAreaValue = "";
      MeasuredDate = DateTime.Now;
      SelectedConditionValue = "";
      TemperatureValue = 0;
    }

    private void EditWeather(WeatherListViewModel weather)
    {
      SelectedIndex = 2;
      SelectedAreaValue = weather.ZipCode;
      MeasuredDate = weather.MeasuredDateValue;
      SelectedConditionValue = weather.ConditionValue;
      TemperatureValue = weather.TemperatureValue;
    }
  }
}
