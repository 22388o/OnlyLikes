using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NostrTypes.Events
{
    public class Message
    {
        public string? Type { get; set; }
        public string? SubscriptionId { get; set; }
        public JObject? Payload { get; set; }
    }
}
