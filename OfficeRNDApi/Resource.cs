using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace OfficeRndApi {
  public class Resource {
    public enum ResourceType {
      meeting_room,
      team_room,
      desk_tr,
      desk,
      hotdesk
    }
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("rate")]
    public string rate { get; set; }

    [JsonProperty("office")]
    public string office { get; set; }

    [JsonProperty("room")]
    public string room { get; set; }

    [JsonProperty("type")]
    public ResourceType type { get; set; }

    [JsonExtensionData]
    private IDictionary<string, JToken> unknownFields;
  }
}
