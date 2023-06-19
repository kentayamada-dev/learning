namespace Domain.Exceptions
{
  public sealed class InputException : BaseException
  {
    public InputException(string message)
      : base(message) { }

    public override ExceptionKind Kind => ExceptionKind.Error;
  }
}
