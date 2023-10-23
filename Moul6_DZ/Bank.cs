using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moul6_DZ
{
    public class Bank
    {
        private Client[] clients;

        public Bank()
        {
            clients = new Client[0];
        }

        public void AddClient(Client client)
        {
            Array.Resize(ref clients, clients.Length + 1);
            clients[clients.Length - 1] = client;
        }

        public Client FindClient(string accountNumber)
        {
            foreach (var client in clients)
            {
                if (client.Account.AccountNumber == accountNumber)
                {
                    return client;
                }
            }
            return null;
        }
    }
}
