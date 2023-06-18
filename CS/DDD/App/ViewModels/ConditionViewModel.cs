using Domain.ValueObjects;

namespace App.ViewModels
{
  public sealed class ConditionViewModel
  {
    private readonly Condition _condition;

    public ConditionViewModel(Condition condition)
    {
      _condition = condition;
    }

    public string DisplayValue => _condition.DisplayValue;
    public string Value => _condition.Value;
  }
}
