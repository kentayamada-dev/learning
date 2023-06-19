using Domain.Exceptions;

namespace Domain.Modules.Helpers
{
  public static class Guard
  {
    public static void IsStringEmpty(string str, string message)
    {
      if (str == "")
      {
        throw new InputException(message);
      }
    }
  }
}
