using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class MarketPlace
    {
        private ProviderCommunication providerCommunication;
        private Site site;
        private Database database;

        public MarketPlace()
        {
            providerCommunication = new();
            site = new();
            database = new();
        }

        public void ProductReceipt()
        {
            providerCommunication.Receive();
            site.Placement();
            database.Insert();
        }

        public void ProductRelease()
        {
            providerCommunication.Payment();
            site.Del();
            database.Delete();
        }
    }
}
