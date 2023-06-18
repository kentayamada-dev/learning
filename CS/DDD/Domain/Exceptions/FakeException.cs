namespace Domain.Exceptions
{
  public sealed class FakeException : BaseException
  {
    public FakeException(string message, Exception Exception)
      : base(message, Exception) { }

    public override ExceptionKind Kind => ExceptionKind.Error;
  }
}
