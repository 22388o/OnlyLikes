using Websocket.Client;

namespace Relays;

public class Relay {
    private readonly WebsocketClient _client;
    public List<string> _queue = new();
    public Relay(Uri uri) {
        _client = new WebsocketClient(uri);
        _client.MessageReceived.Subscribe(msg => {
            Console.WriteLine(msg);
            _queue.Add(msg.ToString());
        });
    }

    public void Listen() {
        _client.Start();
    }

    public List<string> GetEvents() {
        return _queue;
    }

    public void Send(string msg) {
        _client.Send(msg);
    }
}