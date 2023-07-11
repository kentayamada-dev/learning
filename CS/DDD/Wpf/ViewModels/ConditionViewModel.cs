using Domain.ValueObjects;

namespace Wpf.ViewModels
{
  internal sealed class ConditionViewModel
  {
    private readonly Condition _condition;

    internal ConditionViewModel(Condition condition)
    {
      _condition = condition;
    }

    public string DisplayValue => _condition.DisplayValue;
    public string Value => _condition.Value;
  }
}
