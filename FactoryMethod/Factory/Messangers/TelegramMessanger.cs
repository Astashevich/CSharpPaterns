namespace FactoryMethod.Factory.Messangers
{
    /// <summary>
    /// Implementation of the Telegram messenger.
    /// </summary>
    public class TelegramMessanger : MessangerBase
    {
        /// <summary>
        /// Create an instance of the Telegram messenger.
        /// </summary>
        /// <param name="name"> Login. </param>
        /// <param name="password"> Password. </param>
        public TelegramMessanger(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// User authorization in Telegram.
        /// </summary>
        /// <returns> Authorization success. </returns>
        public override bool Authorize()
        {
            // TODO: calling the Telegram API for authorization.
            // Here should be the code for accessing the Telegram servers.
            // It's omitted to save time.
            Console.WriteLine($"Authorization in Telegram of a user with name {UserName} and password {Password}");
            return true;
        }

        /// <summary>
        /// Create a message ready to be sent to Telegram.
        /// This is a FACTORY METHOD. Or rather, its specific implementation for Telegram.
        /// </summary>
        /// <param name="text"> Telegram message text. </param>
        /// <param name="source"> Message sender. </param>
        /// <param name="target"> The recipient of the message. </param>
        /// <returns> Telegram message ready to be sent. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // If necessary, additional actions can be added here.
            // For example, perform logging.
            var message = new TelegramMessage(text, source, target);
            return message;
        }
    }
}
