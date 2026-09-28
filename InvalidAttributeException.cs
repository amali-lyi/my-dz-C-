namespace DotNetLessons;

public class InvalidAttributeException : Exception
{
    public string AttributeName { get; }

    public InvalidAttributeException(string attributeName, string message)
        : base(message)
    {
        AttributeName = attributeName;
    }
}