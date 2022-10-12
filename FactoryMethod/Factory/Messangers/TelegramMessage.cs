namespace FactoryMethod.Factory.Messangers
{
    /// <summary>
    /// Telegram message implementation.
    /// Accepts messages of any length.
    /// </summary>
    public class TelegramMessage : MessageBase
    {
        /// <summary>
        /// Create a new Telegram message instance.
        /// </summary>
        /// <param name="text"> Message text. </param>
        /// <param name="source"> Sender. </param>
        /// <param name="target"> Receiver. </param>
        public TelegramMessage(string text, string source, string target) : base(text, source, target) { }

        /// <summary>
        /// Send Telegram message.
        /// </summary>
        public override void Send()
        {
            // TODO: Calling the Telegram API to send a message.
            // Here should be the code for accessing the Telegram servers.
            // Simplified to save time.
            Console.WriteLine($"Telegram: Text from @{Source} to @{Target}: {Text}");
        }
    }
}
