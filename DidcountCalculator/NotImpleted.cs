//total < 10 - 1%
//total >= 10 && total < 20 - 5%
//total >= 20 - 10%



using System.Runtime.Serialization;

[Serializable]
internal class NotImpleted : Exception
{
    public NotImpleted()
    {
    }

    public NotImpleted(string? message) : base(message)
    {
    }

    public NotImpleted(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NotImpleted(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}