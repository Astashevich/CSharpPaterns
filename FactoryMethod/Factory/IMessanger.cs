namespace FactoryMethod.Factory
{
    /// <summary>
    /// The base interface that any messenger should implement.
    /// In order to add a new messenger, you need to implement two interfaces:
    /// IMessanger (this) - for the messenger and IMessage - for the message of this messenger.
    /// </summary>
    public interface IMessanger
    {
        string UserName { get; }
        string Password { get; }
        bool Connected { get; }
        IMessage CreateMessage(string text, string source, string target);
        bool Authorize();
    }
}
