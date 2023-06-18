using Domain.ValueObjects;

namespace Domain.Entities
{
  public sealed class AreaEntity
  {
    public ZipCode ZipCode { get; }
    public StateAbbr StateAbbr { get; }

    public AreaEntity(string zipCode, string stateAbbr)
    {
      ZipCode = new ZipCode(zipCode);
      StateAbbr = new StateAbbr(stateAbbr);
    }
  }
}
