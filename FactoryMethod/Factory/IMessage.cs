namespace FactoryMethod.Factory
{
    /// <summary>
    /// Base interface that any type of messenger messages should implement.
    /// To add a new messenger message type
    /// need to implement a couple of interfaces:
    /// IMessage (this one) for the message type and IMessenger for connecting to the messenger API.
    /// </summary>
    public interface IMessage
    {
        string Text { get; }
        string Target { get; }
        string Source { get; }
        void Send();
    }
}
