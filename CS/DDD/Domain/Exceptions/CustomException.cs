namespace Domain.Exceptions
{
  public sealed class CustomException : Exception
  {
    public enum ExceptionKind
    {
      Information,
      Warning,
      Error,
    }

    public ExceptionKind Kind { get; }

    internal CustomException(string message, ExceptionKind kind, Exception? exception = null)
      : base(message, exception)
    {
      Kind = kind;
    }
  }
}
