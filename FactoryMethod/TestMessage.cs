namespace FactoryMethod
{
    // <summary>
    /// Message package.
    /// Contains all the necessary information to send.
    /// </summary>
    public class TestMessage
    {
        /// <summary>
        /// Message text.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// The recipient of the message.
        /// </summary>
        public string Target { get; }

        /// <summary>
        /// The sender of the message.
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// Create a new message instance.
        /// </summary>
        /// <param name="text"> Message text. </param>
        /// <param name="source"> Sender. </param>
        /// <param name="target"> Receiver. </param>
        public TestMessage(string text, string source, string target)
        {
            #region Проверяем входные аргументы на корректность
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text), "The message text cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source), "The sender's name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(target), "The recipient's name cannot be empty.");
            }
            #endregion


            // The number of characters in a Twitter message is limited to 140.
            // Anything more is simply ignored.
            if (text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
            Source = source;
            Target = target;
        }
    }
}
