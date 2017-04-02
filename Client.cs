namespace BankSimulation
{
    public class Client
    {
        private string name;
        private ClientType client;

        public Client(string name, ClientType client)
        {
            this.name = name;
            this.client = client;
        }

        public string Name
        {
            get { return this.name; }
        }

        public ClientType ClientType
        {
            get { return this.client; }
        }
    }
}
