namespace FactoryMethod.Factory.Messangers
{
    /// <summary>
    /// Implementation of the Instagram message.
    /// Receives a message as a picture.
    /// </summary>
    public class InstagramMessage : MessageBase
    {
        /// <summary>
        /// Create a new Instagram message instance.
        /// </summary>
        /// <param name="text"> The path to the image file. </param>
        /// <param name="source"> Sender. </param>
        /// <param name="target"> Receiver. </param>
        public InstagramMessage(string text, string source, string target) : base(text, source, target)
        {
            if (File.Exists(text))
            {
                var imageBytes = File.ReadAllBytes(text);
                var base64String = Convert.ToBase64String(imageBytes);
                Text = base64String;
            }
        }

        /// <summary>
        /// Send a message to Instagram.
        /// </summary>
        public override void Send()
        {
            // TODO: Calling the Instagram API to send a message.
            // Here should be the code to contact the Instagram servers.
            // Simplified to save time.
            Console.WriteLine($"Instagram: Photo by @{Source} for @{Target}: {Text}");
        }
    }
}
