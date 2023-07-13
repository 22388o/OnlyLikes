using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NostrTypes.Events;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OnlyLikesTestbed
{
    public partial class MainWindow : Form
    {
        private NostrTypes.Relays.Relay relay;
        private BindingList<NostrTypes.Events.Event> timeline;
        List<string> tempEventBuffer = new();
        public MainWindow()
        {
            InitializeComponent();
            timeline = new();
            relay = new(new Uri("wss://relay.damus.io"));
            timelineView.DataSource = timeline;
            relay.MessageReceived += relayGotMessage;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            relay.Listen();
            relay.Send("[\"REQ\", \"abcde12345\", { \"kinds\":[1] }]");
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            tempEventBuffer.AddRange(relay.GetEvents());
        }

        private void deserializeButton_Click(object sender, EventArgs e)
        {

            JsonSerializer serializer = new JsonSerializer();
            for (var l = 0; l < tempEventBuffer.Count(); l++)
            {
                var item = tempEventBuffer[l];
                if (item == null) continue;
                JArray? m = serializer.Deserialize<JArray>(new JsonTextReader(new StringReader(item)));

                if (m == null || m.Count != 3 || m[0] == null || m[1] == null || m[2] == null) continue;
                if (m[2].ToString() == "EOSE") continue;

                Event? o = serializer.Deserialize<Event>(new JsonTextReader(new StringReader(m[2].ToString())));

                if (o == null) continue;
                timeline.Add(o);
            }
            timelineView.DataSource = timeline;
            tempEventBuffer.Clear();
        }

        private void relayGotMessage(object? sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Action action = () =>
                {
                    readButton_Click(this, e);
                    deserializeButton_Click(this, e);
                };
                this.Invoke(action);
            }
            else
            {
                readButton_Click(this, e);
                deserializeButton_Click(this, e);
            }
        }
    }
}