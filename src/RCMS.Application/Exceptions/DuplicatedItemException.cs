namespace RCMS.Exceptions;

public class DuplicatedItemException : Exception
{
    public DuplicatedItemException()
    {
    }

    public DuplicatedItemException(string message) : base(message)
    {
    }
    
    public DuplicatedItemException(string message, Exception innerException) : base(message, innerException)
    {
    }
}