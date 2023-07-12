namespace Domain.Repositories
{
  public interface IWeatherEditorRepository
  {
    void Edit(string? zipCode, DateTime? measuredDate, float? temperature, string? condition);
  }
}
