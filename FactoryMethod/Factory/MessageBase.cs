namespace FactoryMethod.Factory
{
    /// <summary>
    /// A helper abstract class for the message,
    /// which helps reduce the amount of code and reduce duplication.
    /// Inheriting it is not necessary at all, it is enough to implement the IMessage interface.
    /// But it helps to reduce the amount of duplicated code a little,
    /// due to the fact that you do not need to declare properties and a constructor.
    /// </summary>
    public abstract class MessageBase : IMessage
    {
        /// <summary>
        /// Message text.
        /// </summary>
        public string Text { get; protected set; }

        /// <summary>
        /// The recipient of the message.
        /// </summary>
        public string Target { get; }

        /// <summary>
        /// Message sender.
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// Create a new message instance.
        /// </summary>
        /// <param name="text"> Message text. </param>
        /// <param name="source"> Sender. </param>
        /// <param name="target"> Receiver. </param>
        public MessageBase(string text, string source, string target)
        {
            #region Check input arguments for correctness
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text), "Message text cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source), "Sender name cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(target), "Recipient name cannot be null.");
            }
            #endregion

            Text = text;
            Source = source;
            Target = target;
        }

        /// <summary>
        /// Send a message.
        /// </summary>
        public abstract void Send();
    }
}
