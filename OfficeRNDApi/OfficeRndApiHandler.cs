using System;
using System.Net;
using System.Text.Json;

namespace OfficeRndApi {
  public static class OfficeRndApiHandler {
    public static Token GetToken(string clientId, string clientSecret) {
      using (WebClient wc = new WebClient()) {
        wc.Headers[HttpRequestHeader.ContentType] =
            "application/x-www-form-urlencoded";
        try {
          string res = wc.UploadString(
              "https://identity.officernd.com/oauth/token",
              "POST",
              $"client_id={clientId}&" +
              $"client_secret={clientSecret}&" +
              "grant_type=client_credentials&" +
              "scope=officernd.api.read officernd.api.write"
          );
          return JsonSerializer.Deserialize<Token>(res);
        } catch (WebException e) {
          Console.WriteLine(e.Message);
          return null;
        }
      }
    }
    public static void GetData() {
      throw new NotImplementedException();
    }
  }
}
