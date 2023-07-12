using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace NostrTypes.Events
{
    public class Event
    {
        /// <summary>
        /// 32-bytes lowercase hex-encoded sha256 of the serialized event data
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 32-bytes lowercase hex-encoded public key of the event creator
        /// </summary>
        [JsonPropertyName("pubkey")]
        public string? PubKey { get; set; }

        /// <summary>
        /// unix timestamp in seconds
        /// </summary>
        [JsonPropertyName("created_at")]
        public ulong Created_At { get; set; }

        /// <summary>
        /// Integer type of message
        /// </summary>
        [JsonPropertyName("kind")]
        public int Kind { get; set; }

        /// <summary>
        /// ["e", 32-bytes hex of the id of another event,recommended relay URL],
        /// ["p", 32-bytes hex of a pubkey, recommended relay URL]
        /// </summary>
        [JsonPropertyName("tags")]
        public List<List<string>>? Tags { get; set; }

        /// <summary>
        /// Arbitrary string
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 64-bytes hex of the signature of the sha256 hash of the serialized event data,
        /// which is the same as the "id" field
        /// </summary>
        [JsonPropertyName("sig")]
        public string? Sig { get; set; }
    }
}
