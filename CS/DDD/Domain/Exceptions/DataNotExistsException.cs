namespace Domain.Exceptions
{
  public sealed class DataNotExistsException : BaseException
  {
    public DataNotExistsException() : base("Data Does Not Exists.")
    {
    }

    public override ExceptionKind Kind => ExceptionKind.Info;
  }
}
