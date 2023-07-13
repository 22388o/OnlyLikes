using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Websocket.Client;

namespace NostrTypes.Relays
{
    public class Relay
    {
        public event EventHandler? MessageReceived;

        private readonly WebsocketClient _client;
        public List<string> _queue = new();
        public Relay(Uri uri)
        {
            _client = new WebsocketClient(uri);
            _client.MessageReceived.Subscribe(msg => {
                Console.WriteLine(msg);
                _queue.Add(msg.ToString());
                MessageReceived?.Invoke(this, new());
            });
        }

        public void Listen()
        {
            _client.Start();
        }

        public List<string> GetEvents()
        {
            List<string> listToReturn = new List<string>(_queue);
            _queue.Clear();
            return listToReturn;
        }

        public void Send(string msg)
        {
            _client.Send(msg);
        }
        protected virtual void OnMessageReceived(EventArgs e)
        {
            MessageReceived?.Invoke(this, e);
        }
    }
}
