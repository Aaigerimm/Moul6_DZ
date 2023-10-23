namespace ClassLibrary2
{
    public class BankBase
    {

        public Client OpenAccount(string name, string password)
        {
            int clientId = GenerateUniqueClientId();
            Client client = new Client(name, clientId, password);
            clients.Add(client);
            return client;
        }
    }
}