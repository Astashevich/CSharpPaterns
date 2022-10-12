namespace FactoryMethod.Factory.Messangers
{
    /// <summary>
    /// Implementation of the Twitter messenger.
    /// </summary>
    public class TwitterMessanger : MessangerBase
    {
        /// <summary>
        /// Create an instance of the Twitter messenger.
        /// </summary>
        /// <param name="name"> Login. </param>
        /// <param name="password"> Password. </param>
        public TwitterMessanger(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// User authorization on Twitter.
        /// </summary>
        /// <returns> Authorization success. </returns>
        public override bool Authorize()
        {
            // TODO: Calling the Twitter API for authorization.
            // Here should be the code to contact the Twitter servers.
            // It's omitted to save time.
            Console.WriteLine($"Twitter login for user {UserName} and password {Password}");
            return true;
        }

        /// <summary>
        /// Create a message ready to be sent to Twitter.
        /// This is a FACTORY METHOD. And to be more precise, its specific implementation for Twitter.
        /// </summary>
        /// <param name="text"> The text of the Twitter message. </param>
        /// <param name="source"> Message sender. </param>
        /// <param name="target"> The recipient of the message. </param>
        /// <returns> A Twitter message ready to be sent. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // If necessary, additional actions can be added here.
            // For example, if Comrade Major comes and says that all messages must be
            // go to him for verification, then this can be added here.
            var message = new TwitterMessage(text, source, target);
            return message;
        }
    }
}
