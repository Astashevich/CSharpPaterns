namespace FactoryMethod.Factory
{
    /// <summary>
    /// A helper abstract messenger class to reduce the amount of code.
    /// It is not necessary to inherit it, it is enough to implement the IMessanger interface.
    /// But it helps to reduce the amount of duplicated code
    /// due to the fact that it is not gentle to declare properties and a constructor in each successor.
    /// </summary>
    public abstract class MessangerBase : IMessanger
    {
        /// <summary>
        /// User login.
        /// </summary>
        public string UserName { get; }

        /// <summary>
        /// User password.
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Successful connection and authorization.
        /// </summary>
        public bool Connected { get; }

        /// <summary>
        /// Instantiation of the messenger and authorization.
        /// </summary>
        /// <param name="name"> Username. </param>
        /// <param name="password"> User password. </param>
        public MessangerBase(string name, string password)
        {
            // Don't forget to check the input parameters before authorization.
            if (!(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = name;
                Password = password;
                Connected = Authorize();
            }
            else
            {
                Connected = false;
            }
        }

        /// <summary>
        /// Perform authorization in the messenger.
        /// </summary>
        /// <returns> Authorization success. </returns>
        public abstract bool Authorize();

        /// <summary>
        /// Create a message ready to be sent.
        /// This is a FACTORY METHOD. And to be more precise, the factory method interface is declared, but not implemented.
        /// </summary>
        /// <param name="text"> Message text. </param>
        /// <param name="source"> Message sender. </param>
        /// <param name="target"> The recipient of the message. </param>
        /// <returns> Message ready to be sent. </returns>
        public abstract IMessage CreateMessage(string text, string source, string target);
    }
}
