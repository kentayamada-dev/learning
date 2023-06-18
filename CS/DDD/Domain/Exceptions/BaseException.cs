namespace Domain.Exceptions
{
  public abstract class BaseException : Exception
  {
    public BaseException(string message, Exception? Exception = null)
      : base(message, Exception) { }

    public enum ExceptionKind
    {
      Info,
      Warning,
      Error,
    }

    public abstract ExceptionKind Kind { get; }
  }
}
