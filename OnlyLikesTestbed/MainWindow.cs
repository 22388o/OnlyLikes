using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NostrTypes.Events;
using System.ComponentModel;

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
                JArray? i = JArray.Parse(item);
                if (i == null || i.First.ToString() == "EOSE") continue;
                NostrTypes.Events.Event? o = serializer.Deserialize<NostrTypes.Events.Event>(new JsonTextReader(new StringReader(i.Last.ToString())));
                if (o == null) continue;
                timeline.Add(o);
                //JsonTextReader reader = new JsonTextReader(new StringReader(item));
                //while (reader.Read())
                //{
                //    if (reader.Value != null)
                //    {
                //        System.Diagnostics.Debug.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                //    }
                //    else
                //    {
                //        System.Diagnostics.Debug.WriteLine("Token: {0}", reader.TokenType);
                //    }
                //}
            }
            timelineView.DataSource = timeline;
        }
    }
}