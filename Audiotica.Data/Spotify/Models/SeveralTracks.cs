using System.Collections.Generic;
using Newtonsoft.Json;

namespace Audiotica.Data.Spotify.Models
{
    public class SeveralTracks
    {
        [JsonProperty("tracks")]
        public List<FullTrack> Tracks { get; set; }
    }
}