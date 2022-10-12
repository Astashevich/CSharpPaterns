namespace FactoryMethod
{
    /// <summary>
    /// A class that emulates working with Twitter.
    /// Allows you to log in and send messages.
    /// </summary>
    public class TestMessanger
    {
        /// <summary>
        /// Username. 
        /// </summary>
        public string UserName { get; }

        /// <summary>
        /// User password.
        /// P.S. Never store user passwords in plain text.
        /// Use hash algorithms and compare hashes.
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Successful connection and authorization on Twitter.
        /// </summary>
        public bool Connected { get; }

        /// <summary>
        /// Create a new instance of the Twitter messenger and perform authorization.
        /// </summary>
        /// <param name="userName"> Username. </param>
        /// <param name="password"> User password. </param>
        public TestMessanger(string userName, string password)
        {
            if(!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
            {
                UserName = userName;
                Password = password;
                Connected = ConnectToTwitter();
            }
            else
            {
                Connected = false;
            }
        }

        /// <summary>
        /// Send a message to the user.
        /// </summary>
        /// <param name="text"> Message text. </param>
        /// <param name="source"> Sender. </param>
        /// <param name="target"> Receiver. </param>
        public void SendMessage(string text, string source, string target)
        {
            #region Check input arguments for correctness
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException(nameof(text), "The message text cannot be empty.");

            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentNullException(nameof(source), "The sender's name cannot be empty.");

            if (string.IsNullOrWhiteSpace(target))
                throw new ArgumentNullException(nameof(target), "The recipient's name cannot be empty.");

            if (text.Length > 140)
                throw new ArgumentException("The text of the message cannot be more than 140 characters.", nameof(text));
            #endregion

            var message = new TestMessage(text, source, target);
            SendMessageToTwitter(message);
        }

        private bool ConnectToTwitter()
        {
            // TODO: Calling the Twitter API for authorization.
            // Here should be the code to contact the Twitter servers.
            // Simplified to save time.
            Console.WriteLine($"Authorization on Twitter user with name {UserName} and password {Password}");
            return true;
        }

        /// <summary>
        /// Send a message on Twitter.
        /// </summary>
        /// <param name="message"> Message to send. </param>
        private void SendMessageToTwitter(TestMessage message)
        {
            // TODO: Calling the Twitter API to send a message.
            // Here should be the code to contact the Twitter servers.
            // Simplified to save time.
            Console.WriteLine($"Twitter: {message.Text}");
        }
    }
}
