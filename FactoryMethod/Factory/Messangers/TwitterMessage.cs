using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory.Messangers
{
    /// <summary>
    /// Implementation of the Twitter message.
    /// Accepts messages with a length of 140 characters.
    /// </summary>
    public class TwitterMessage : MessageBase
    {
        /// <summary>
        /// Create a new Twitter message instance.
        /// </summary>
        /// <param name="text"> Message text, up to 140 characters. </param>
        /// <param name="source"> Sender. </param>
        /// <param name="target"> Receiver. </param>
        public TwitterMessage(string text, string source, string target) : base(text, source, target)
        {
            if (text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
        }

        /// <summary>
        /// Send a tweet message.
        /// </summary>
        public override void Send()
        {
            // TODO: Calling the Twitter API to send a message.
            // Here should be the code to contact the Twitter servers.
            // Simplified to save time.
            Console.WriteLine($"Twitter: Tweet from @{Source} to @{Target}: {Text}");
        }
    }
}
