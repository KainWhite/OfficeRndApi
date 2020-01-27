using System;

namespace OfficeRndApi {
  class Program {
    private static string clientId = "o2cBTqaINCOWVBCd";
    private static string clientSecret = "89c7n4zyKuegDE0wA2J40oDgcXmVUQvH";
    static void Main(string[] args) {
      var token = OfficeRndApiHandler.GetToken(clientId, clientSecret);
      var resources = OfficeRndApiHandler.GetResources(token);
      if(resources != null) {
        foreach (var resource in resources) {
          Console.WriteLine(resource.name);
          //Console.WriteLine(resource.type);
        }
      }
    }
  }
}
