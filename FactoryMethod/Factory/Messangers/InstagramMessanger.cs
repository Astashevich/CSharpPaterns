namespace FactoryMethod.Factory.Messangers
{
    /// <summary>
    /// Implementation of the Instagram messenger.
    /// </summary>
    public class InstagramMessanger : MessangerBase
    {
        /// <summary>
        /// Create an instance of the Instagram messenger.
        /// </summary>
        /// <param name="name"> Login. </param>
        /// <param name="password"> Password. </param>
        public InstagramMessanger(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// User authorization on Instagram.
        /// </summary>
        /// <returns> Authorization success. </returns>
        public override bool Authorize()
        {
            // TODO: Calling the Instagram API for authorization.
            // Here should be the code to contact the Instagram servers.
            // It's omitted to save time.
            Console.WriteLine($"Authorizing Instagram user with name {UserName} and password {Password}");
            return true;
        }

        /// <summary>
        /// Create a message ready to be sent to Twitter.
        /// This is a FACTORY METHOD. And to be more precise, its specific implementation for Twitter.
        /// </summary>
        /// <param name="text"> The path to the image file. </param>
        /// <param name="source"> Message sender. </param>
        /// <param name="target"> The recipient of the message. </param>
        /// <returns> A Twitter message ready to be sent. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // If necessary, additional actions can be added here.
            // For example, perform image analysis to improve them or train neural networks.
            var message = new InstagramMessage(text, source, target);
            return message;
        }
    }
}
