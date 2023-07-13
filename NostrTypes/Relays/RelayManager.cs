using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NostrTypes.Relays
{
    internal class RelayManager
    {
        public HashSet<Events.Event> Events = new();
        private HashSet<Uri> RelayUris = new();

        public bool AddRelay(string url)
        {
            Uri uri;
            try
            {
                uri = new(url);
                RelayUris.Add(uri);
                // TODO: Add connect
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Failed to add: {1} to the relay pool.", url); 
                return false;
            }
            return true;
        }

        public bool RemoveRelay(string url)
        {
            Uri uri;
            try
            {
                uri = new(url);
                // TODO: Add disconnect
                RelayUris.Remove(uri);
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Failed to remove: {1} from the relay pool.", url);
                return false;
            }

            return true;
        }

        // TODO: Add listener for disconnect event
    }
}
