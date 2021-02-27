using Newtonsoft.Json;

namespace Hotels.API.Abstract
{
    public class Resource
    {
        [JsonProperty(Order = 1)]
        public string Href { get; set; }
    }
}