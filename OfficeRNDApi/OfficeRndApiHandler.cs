using Newtonsoft.Json;
using System;
using System.Net;

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
          return JsonConvert.DeserializeObject<Token>(res);
        } catch (Exception e) {
          Console.WriteLine(e.Message);
          return null;
        }
      }
    }
    public static Resource[] GetResources(in Token token) {
      using (WebClient wc = new WebClient()) {
        wc.Headers[HttpRequestHeader.ContentType] =
            "application/x-www-form-urlencoded";
        wc.Headers.Add("Authorization",
                       token.tokenType + " " + token.accessToken);
        try {
          string res = wc.DownloadString(
              "https://app.officernd.com/i/organizations/vsgate-officernd-trial/resources");
          //string res = "[{\"name\":\"lol\",\"type\":\"desk\"},{\"name\":\"kek\",\"type\":\"team_room\"}]";
          return JsonConvert.DeserializeObject<Resource[]>(res);
        } catch (Exception e) {
          Console.WriteLine(e.Message);
          return null;
        }
      }
    }
  }
}
