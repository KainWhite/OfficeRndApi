using Newtonsoft.Json;

namespace OfficeRndApi {
  public class Token {
    [JsonProperty("access_token")]
    public string accessToken { get; set; }

    [JsonProperty("token_type")]
    public string tokenType { get; set; }

    [JsonProperty("expires_in")]
    public int expiresIn { get; set; }

    [JsonProperty("scope")]
    public string scope { get; set; }
  }
}
